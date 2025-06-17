using System.Collections.Generic;
using Chizl.RegexPatterns.utils;

namespace Chizl.RegexPatterns.Personal
{
    internal static class IdentifyExtensions
    {
        private static Dictionary<Identify, IdentifyAttribute> _identifyAttribute = new Dictionary<Identify, IdentifyAttribute>();
        public static bool DropAttribute(this Identify @this) => _identifyAttribute.Remove(@this);

        public static IdentifyAttribute CurrencyAttr(this Identify @this) => GetAttribute(@this);
        public static string IdentifyName(this Identify @this) => GetAttribute(@this).IdentifyName;
        public static string MatchPattern(this Identify @this) => GetAttribute(@this).MatchPattern;
        public static string ReplacePattern(this Identify @this) => GetAttribute(@this).ReplacePattern;
        public static string PatternBreakDown(this Identify @this) => GetAttribute(@this).PatternBreakDown;

        private static IdentifyAttribute GetAttribute(Identify enumVal)
        {
            if (_identifyAttribute.TryGetValue(enumVal, out IdentifyAttribute attrib))
                return attrib;

            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.Name());
            var attributes = memInfo[0].GetCustomAttributes(typeof(IdentifyAttribute), false);
            var retVal = (attributes.Length > 0) ? (IdentifyAttribute)attributes[0] : null;

            if (retVal != null)
                _identifyAttribute.Add(enumVal, retVal);

            return retVal;
        }
    }
}
