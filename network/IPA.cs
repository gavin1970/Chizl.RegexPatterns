using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Chizl.RegexPatterns.Network
{
    /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/*' />
    public sealed class IPA
    {
        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/*' />
        internal IPA() { }

        #region Templates
        const string _ipv4Template = @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})$";
        const string _ipv6Template = @"^((([0-9A-Fa-f]{1,4}:){7}([0-9A-Fa-f]{1,4}|:))|(([0-9A-Fa-f]{1,4}:){6}(:[0-9A-Fa-f]{1,4}|((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){5}(((:[0-9A-Fa-f]{1,4}){1,2})|:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3})|:))|(([0-9A-Fa-f]{1,4}:){4}(((:[0-9A-Fa-f]{1,4}){1,3})|((:[0-9A-Fa-f]{1,4})?:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){3}(((:[0-9A-Fa-f]{1,4}){1,4})|((:[0-9A-Fa-f]{1,4}){0,2}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){2}(((:[0-9A-Fa-f]{1,4}){1,5})|((:[0-9A-Fa-f]{1,4}){0,3}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(([0-9A-Fa-f]{1,4}:){1}(((:[0-9A-Fa-f]{1,4}){1,6})|((:[0-9A-Fa-f]{1,4}){0,4}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:))|(:(((:[0-9A-Fa-f]{1,4}){1,7})|((:[0-9A-Fa-f]{1,4}){0,5}:((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)(\.(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)){3}))|:)))(%.+)?$";
        #endregion

        #region Public Properties
        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/properties/property[@name="IpV4"]/*' />
        public string Ipv4 => _ipv4Template;

        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/properties/property[@name="IpV6"]/*' />
        public string IpV6 => _ipv6Template;
        #endregion

        #region Public Methods
        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/methods/method[@name="HasZoneID"]/*' />
        public bool HasZoneId(string ipa) => WithZoneId(ipa);

        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/methods/method[@name="IsMatch"]/*' />
        public bool IsMatch(string ipa) => IPAddress.TryParse(ipa, out _);

        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/methods/method[@name="IsIP"]/*' />
        public int IsIP(string ipa)
        {
            // Step 1: Attempt to parse the string into an IPAddress object.
            // This single call handles all complex IPv4 and IPv6 validation rules.
            if (IPAddress.TryParse(ipa, out IPAddress address))
            {
                // Step 2: Check the AddressFamily property of the parsed IPAddress object.
                // This directly tells you if it's IPv4 or IPv6.
                if (address.AddressFamily == AddressFamily.InterNetwork)
                    return 4; // It's an IPv4 address
                else if (address.AddressFamily == AddressFamily.InterNetworkV6)
                    return 6; // It's an IPv6 address

                // In theory, other AddressFamily types could exist (like AppleTalk, NetBIOS),
                // but for typical IP addresses, InterNetwork and InterNetworkV6 are the ones you care about.
                // If TryParse succeeds for something else, it implies a very unusual scenario.
                // For this specific use case, returning 0 might be appropriate for "not a standard IP".
                else
                    return 0; // Unexpected address family, treat as not a recognized IP type for this method's purpose.
            }
            else
                return 0; // TryParse returned false, so it's not a valid IP address at all.
        }
        #endregion

        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/methods/method[@name="IsIPv4"]/*' />
        public bool IsIPv4(string ipa) => IsIP(ipa).Equals(4);

        /// <include file="../docs/IPA.xml" path='extradoc/class[@name="IPA"]/methods/method[@name="IsIPv6"]/*' />
        public bool IsIPv6(string ipa) => IsIP(ipa).Equals(6);

        #region Private Methods
        private bool WithZoneId(string ipa)
        {
            if (IsIP(ipa).Equals(6))
            {
                var ipaS = ipa.Split(new char[] { '%' }, System.StringSplitOptions.RemoveEmptyEntries);
                if (ipaS.Length.Equals(2))
                {
                    if (Regex.Match(ipaS[1], "[0-9]").Success)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }
        #endregion
    }
}