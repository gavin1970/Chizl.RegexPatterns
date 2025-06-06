using System;
using Chizl.RegexPatterns;
using Chizl.RegexPatterns.Finance;

namespace Net8Demo
{
    internal static class MoneyRegexDemo
    {
        private static Money SetDefault()
        {
            var mon = RegexPattern.Money;
            mon.Currency = Currency.USD;

            mon.CurrencySymbolStatus = DisplayStatus.Required;
            mon.MajorUnitStatus = UnitStatus.Required;  //Dollars
            mon.MinorUnitStatus = UnitStatus.Required;  //Cents

            mon.MajorUnitLength.Min = 1;
            mon.MajorUnitLength.Max = 9;
            mon.MinorUnitLength.Min = 2;
            mon.MinorUnitLength.Max = 2;

            return mon;
        }
        internal static void Start()
        {
            var mon = SetDefault();
            DisplayCurrency(mon, "$123456789.12");

            //By changing currency to BIF currency, the enum validates decimal point for that currency.
            //The previous set for MinorUnitStatus was Required.
            //Since BIF has no decimal point and the current MinorUnitStatus is Required, enum validation will
            //automagically reset MinorUnitStatus to Optional.  If MinorUnitStatus was previous set to Deny,
            //it will remain Deny.  The assumption is your system might need MinorUnits, so it's
            //allowed, but not required.
            mon.Currency = Currency.BIF;
            //Changed currency symbol in front.
            //BIF doesn't have a single character currency symbol.
            DisplayCurrency(mon, $"{mon.CurrencySymbolDisplay}123456789");

            //showing a currency that requires UTF8 to display in consoles, but also has a '.' in the middle that is auto escaped.
            mon.Currency = Currency.IQD;
            mon.CurrencySymbolStatus = DisplayStatus.Required;
            mon.MinorUnitStatus = UnitStatus.Required;
            mon.MinorUnitLength.Min = 3;    //upgrading min only, forces max to match, since it's currently setting at 2.

            //Changed currency symbol in front.
            //DJF doesn't have a single character currency symbol.
            DisplayCurrency(mon, $"{mon.CurrencySymbolDisplay}123456789.123");


            //Removed currency symbol in front.
            DisplayCurrency(mon, $"123456789.123");
        }
        private static void DisplayCurrency(Money mon, string value)
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //required if changing configuration.
            mon.RefreshPatterns();

            Console.WriteLine();
            Console.WriteLine("----------------------------\n" +
                              "Currency Standards:\n" +
                              "----------------------------");
            Console.WriteLine($"Currency: {mon.Currency}\n" +
                              $"CountryName: {mon.CountryName}\n" +
                              $"CurrencySymbol: {mon.CurrencySymbol}\n" +
                              $"CurrencySymbolDisplay: {mon.CurrencySymbolDisplay}\n" +
                              $"CurrencyName: {mon.CurrencyName}\n" +
                              $"CurrencyDecimal: {mon.DecimalPoint}");

            Console.WriteLine();
            Console.WriteLine("----------------------------\n" +
                              "User Settings:\n" +
                              "----------------------------");
            Console.WriteLine($"SymbolStatus: {mon.CurrencySymbolStatus}\n" +
                              $"MajorUnitStatus: {mon.MajorUnitStatus}\n" +
                              $"MinorUnitStatus: {mon.MinorUnitStatus}\n" +
                              $"MajorUnitLength: {mon.MajorUnitLength}\n" +
                              $"MinorUnitLength: {mon.MinorUnitLength}");

            Console.WriteLine();
            Console.WriteLine("----------------------------\n" +
                              "Auto-generated Patterns:\n" +
                              "----------------------------");
            Console.WriteLine($"Match Pattern: {mon.MatchPattern}");
            Console.WriteLine($"Replace Pattern: {mon.ReplacePattern}");

            Console.WriteLine();
            Console.WriteLine("----------------------------\n" +
                              "Validation:\n" +
                              "----------------------------");
            Console.WriteLine($"'{value}' - Is Match: {mon.IsMatch(value)}");

            Console.ReadKey(true);
        }
    }
}
