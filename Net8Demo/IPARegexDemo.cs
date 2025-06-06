using System;
using Chizl.RegexPatterns;
using Chizl.RegexPatterns.Network;

namespace Net8Demo
{
    internal static class IPARegexDemo
    {
        internal static void Start()
        {
            Console.Clear();
            var ipa = RegexPattern.IPA;

            DisplayStatus(ipa, "fe80::b21a:76d2:baaa:8b4");
            DisplayStatus(ipa, "fe80::b21a:76d2:baaa:8b4%123");
            DisplayStatus(ipa, "192.168.247.1");
            DisplayStatus(ipa, "192.168.247.256");
            DisplayStatus(ipa, "192.168.1.254");
        }
        private static void DisplayStatus(IPA ipa, string ip)
        {
            Console.WriteLine("After a lot of research, it was determind, that IPv6 really can't be handled by Regex patterns.\n" +
                              "This is because of the many rules wrapped around IPv6.  The one that will be displayed is the\n" +
                              "closest that could be found, but because of the many OR, it allows for characters near the end that\n" +
                              "shouldn't be there.  Validation is actually being done by the IPAddress.TryParse API instead, which\n" +
                              "houses all the rules and matches successfully to all IPv4 and IPv6 scenarios.\n");

            var val = ipa.IsMatch(ip);
            Console.WriteLine($"IP: {ip}");
            Console.WriteLine($"Valid IP: {val}");

            if (val)
            {
                // ipa.IsIPv4(ip) and ipa.IsIPv6(ip) also exists, but IsIP(ip) provides all answers needed for this demo.
                var isIP = ipa.IsIP(ip);
                Console.Write($"Version: 'IPv{isIP}");
                if (isIP.Equals(6) && ipa.HasZoneId(ip)) //HasZoneId uses IsIP internal, but no reason to call it twice.
                    Console.WriteLine($" w/ ZoneID'");
                else
                    Console.WriteLine("'");
            }


            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
