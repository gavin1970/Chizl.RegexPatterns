using Chizl.RegexPatterns;
using Chizl.RegexPatterns.Finance;
using Chizl.RegexPatterns.personal;
using Chizl.RegexPatterns.Personal;
using System;
using System.Net;
using System.Xml.Linq;

namespace Net8Demo
{
    internal class IdentifyRegexDemo
    {
        private static Identity _id = RegexPattern.Identity;

        internal static void Start()
        {
            Console.Clear();
            
            var val = "a123-45-b6789";
            DisplayCurrency(Identify.SSN_Hyphenated, val);
            val = _id.Replace(Identify.SSN_Hyphenated, val);
            DisplayCurrency(Identify.SSN_Unhyphenated, val);

            val = "+1 a(800) 555a1-234";
            DisplayCurrency(Identify.Phone_US_Full, val);
            DisplayCurrency(Identify.Phone_US_Mid, val);

            val = "+1 a(800) 555a-1234";
            DisplayCurrency(Identify.Phone_US_Full, val);
            val = "a(800) 555a-1234";
            DisplayCurrency(Identify.Phone_US_Mid, val);

            val = "800-555-a1234";
            DisplayCurrency(Identify.Phone_US_Full, val);
            DisplayCurrency(Identify.Phone_US_Mid, val);
            val = "555a-1234";
            DisplayCurrency(Identify.Phone_US_Mid, val);

            //DisplayCurrency(Identify.Email, val);
            //DisplayCurrency(Identify.Name, val);
            //DisplayCurrency(Identify.Address, val);
            //DisplayCurrency(Identify.City, val);
            //DisplayCurrency(Identify.State_Full, val);
            //DisplayCurrency(Identify.State_Initials, val);
            //DisplayCurrency(Identify.ZipCode_Hyphenated, val);
            //DisplayCurrency(Identify.ZipCode_Unhyphenated, val);
            //DisplayCurrency(Identify.ZipCode_Short, val);
        }
        private static void DisplayCurrency(Identify ident, string value)
        {
            Console.Clear();

            // Not required if using _id.IsMatch(Identify, value)
            // Is Required if you want to display MatchPattern and ReplacePattern.
            _id.SetIdentify(ident);

            Console.WriteLine();
            Console.WriteLine("----------------------------\n" +
                              "User Settings:\n" +
                              "----------------------------");
            Console.WriteLine($"Identify: {ident}");

            Console.WriteLine();
            Console.WriteLine("----------------------------\n" +
                              "Patterns:\n" +
                              "----------------------------");
            Console.WriteLine($"Match Pattern: {_id.MatchPattern}");
            var patDefined = _id.PatternBreakdown(ident);
            if (!string.IsNullOrWhiteSpace(patDefined))
                Console.WriteLine($"Match Defined:\n{patDefined}");
            Console.WriteLine($"Replace Pattern: {_id.ReplacePattern}");

            Console.WriteLine();
            Console.WriteLine("----------------------------\n" +
                              "Validation:\n" +
                              "----------------------------");

            // IsMatch with 1 arguement is only valid if IsMatch
            // with 2 arguments or SetIdentify has already been called.
            Console.WriteLine($"'{value}' - Is Match #1: {_id.IsMatch(ident, value)}");
            Console.WriteLine($"'{value}' - Is Match #2: {_id.IsMatch(value)}");

            var rep = _id.Replace(ident, value);
            Console.WriteLine($"'{value}' - Replace: {rep}");
            value = rep;
            Console.WriteLine($"'{value}' - Is Match: {_id.IsMatch(value)}");

            Console.ReadKey(true);
        }
    }
}
