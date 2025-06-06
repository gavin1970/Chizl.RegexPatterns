using System;

namespace Chizl.RegexPatterns
{
    public enum DisplayStatus
    {
        Required,
        Optional,
        Deny,
    }
    public enum UnitStatus
    {
        Required,
        Optional,
        Deny,
    }

    public enum IPMatch
    {
        IPv4,
        IPv6,
        IPv6_ZoneID,
    }

    [Flags]
    public enum AcceptedFormats
    {
        Phones = 1,
        /// <summary>
        /// Requires format '111-22-3333'<br/>
        /// Use Numbers with Size of 9 if you are not looking for '-' in the string.
        /// </summary>
        SSN,
        /// <summary>
        /// Requires: AZaz as the first character then up to 64 bytes before @.<br/>
        /// Within that 64 bytes, there can be letters, numbers, and/or '.', '+', '_', '-'<br/>
        /// Requires @
        /// </summary>
        Email,
        /// <summary>
        /// String in Windows might have '\r'
        /// </summary>
        CarriageReturn,
        /// <summary>
        /// String in all OS's might have '\n'
        /// </summary>
        LineFeed,
        /// <summary>
        /// Allow all numbers 0 through 9
        /// </summary>
        Numbers,
        /// <summary>
        /// Allow Uppercase A through Z
        /// </summary>
        AzUpperCase,
        /// <summary>
        /// Allow Lowercase A through Z
        /// </summary>
        AzLowerCase,
    }
}
