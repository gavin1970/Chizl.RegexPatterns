using System;
using System.Linq;

namespace Chizl.RegexPatterns.Finance
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.All)]
    public sealed class CurrencyAttribute : Attribute
    {
        //Allowed range
        private readonly MinMax _decimalMinMax = MinMax.SetRange(0, 3);

        internal CurrencyAttribute(int decimalPoint, Currency currency, string countryName, string currencyName, int[] currencySymbolDecs)
        {
            //re-eval and ensure deciaml is within overall ranges expected.
            decimalPoint = _decimalMinMax.InRange(decimalPoint);

            this.DecimalPoint = decimalPoint;
            this.HasMinorUnits = !decimalPoint.Equals(0);
            this.CountryName = countryName;
            this.CurrencyName = currencyName;
            this.Currency = $"{currency}";
            this.CurrencySymbol = string.Join("", currencySymbolDecs.Select(ch => char.ConvertFromUtf32(ch)));
        }

        /// <summary>
        /// Auto set when if DecimalPoint has a value above zero.
        /// </summary>
        public bool HasMinorUnits { get; }
        /// <summary>
        /// Maximum Decimal point for currency with MinorUnits (aka Cents).
        /// </summary>
        public int DecimalPoint { get; }
        /// <summary>
        /// Official Currency Code
        /// </summary>
        public string Currency { get; }
        /// <summary>
        /// Country or Unit Name where currency is used.<br/>
        /// e.g. "Bulgaria", "Colombia", "United States"
        /// </summary>
        public string CountryName { get; }
        /// <summary>
        /// Currency Name<br/>
        /// e.g. "Lev", "Peso", "Dollar"
        /// </summary>
        public string CurrencyName { get; }
        /// <summary>
        /// Currency Symbol<br/>
        /// e.g. "1083, 1074", "$"
        /// </summary>
        public string CurrencySymbol { get; }
    }
}
