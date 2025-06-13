using Chizl.RegexPatterns.utils;
using System;

namespace Chizl.RegexPatterns.Personal
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.All)]
    public sealed class IdentifyAttribute : Attribute
    {
        internal IdentifyAttribute(Identify ident, string matchPattern, string replacePattern, string breakDown = "")
        {
            this.IdentifyName = ident.Name();
            this.MatchPattern = matchPattern;
            this.ReplacePattern = replacePattern;
            this.PatternBreakDown = breakDown;
        }

        public string IdentifyName { get; }
        public string MatchPattern { get; }
        public string ReplacePattern { get; }
        public string PatternBreakDown { get; }
    }
}
