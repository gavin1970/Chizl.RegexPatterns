using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chizl.RegexPatterns.Finance
{
    internal static class CurrencyExtensions
    {
        private static Dictionary<Enum, CurrencyAttribute> _currencyAttribute = new Dictionary<Enum, CurrencyAttribute>();
        public static CurrencyAttribute CurrencyAttr(this Currency @this) => GetAttribute(@this);
        public static bool DropAttributes<T>(this T @this) where T : Enum => _currencyAttribute.Remove(@this);
        public static string CurrencyName(this Currency @this) => GetAttribute(@this).CurrencyName;
        public static string CountryName(this Currency @this) => GetAttribute(@this).CountryName;
        public static bool HasMinorUnits(this Currency @this) => GetAttribute(@this).HasMinorUnits;
        public static string CurrencySymbol(this Currency @this, bool forRegEx = true)
        {
            var currencySymbol = GetAttribute(@this).CurrencySymbol;
            if (forRegEx)
                currencySymbol = Regex.Escape(currencySymbol);
            return currencySymbol;
        }
        public static bool IsRequired(this UnitStatus @this) => @this.Equals(UnitStatus.Required);
        public static bool IsOptional(this UnitStatus @this) => @this.Equals(UnitStatus.Optional);
        public static bool IsDenied(this UnitStatus @this) => @this.Equals(UnitStatus.Deny);
        public static bool IsRequired(this DisplayStatus @this) => @this.Equals(DisplayStatus.Required);
        public static bool IsOptional(this DisplayStatus @this) => @this.Equals(DisplayStatus.Optional);
        public static bool IsDenied(this DisplayStatus @this) => @this.Equals(DisplayStatus.Deny);
        private static CurrencyAttribute GetAttribute(Enum enumVal)
        {
            if (_currencyAttribute.TryGetValue(enumVal, out CurrencyAttribute attrib))
                return attrib;

            var type = enumVal.GetType();
            var memInfo = type.GetMember($"{enumVal}");
            var attributes = memInfo[0].GetCustomAttributes(typeof(CurrencyAttribute), false);
            var retVal = (attributes.Length > 0) ? (CurrencyAttribute)attributes[0] : null;

            if (retVal != null)
                _currencyAttribute.Add(enumVal, retVal);

            return retVal;
        }
    }
}
