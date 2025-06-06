using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Chizl.RegexPatterns.utils
{
    internal static class ChizlExtensions
    {
        /// <summary>
        /// Returns the 'string' name of the Enums value being used.<br/>
        /// <code>
        /// Example:<br/>
        ///     var e = MyEnum.MyProperty<br/>
        ///     Console.WriteLine($"Enum property name: {e.Name()}");
        ///     -- Results: "MyProperty"
        /// </code>
        /// </summary>
        /// <returns>string name of enum property</returns>
        //public static string Name<T>(this T @this) where T : Enum => Enum.GetName(typeof(T), @this) ?? "";
        public static string Name<T>(this T @this) where T : Enum => $"{@this}";
        /// <summary>
        /// Returns the 'int' value of the Enums value being used.<br/>
        /// Returns 
        /// <code>
        /// Example:<br/>
        ///     Console.WriteLine($"Enum property value: {MyEnum.Property.Value()}");
        /// </code>
        /// </summary>
        /// <returns>int value of enum property</returns>
        public static int Value<T>(this T @this) where T : Enum => (int)(object)@this;
    }
}
