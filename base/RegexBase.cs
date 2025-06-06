using System.Text.RegularExpressions;

namespace Chizl.RegexPatterns
{
    /// <include file="../docs/RegexBase.xml" path='extradoc/class[@name="RegexBase"]/*' />
    public abstract class RegexBase
    {
        internal readonly object _locker = new object();
        internal string _matchPattern = string.Empty;
        internal string _replacePattern = string.Empty;

        /// <include file="../docs/RegexBase.xml" path='extradoc/class[@name="RegexBase"]/properties/property[@name="MatchPattern"]/*' />
        public string MatchPattern { get { lock (_locker) return _matchPattern; } }
        
        /// <include file="../docs/RegexBase.xml" path='extradoc/class[@name="RegexBase"]/properties/property[@name="ReplacePattern"]/*' />
        public string ReplacePattern { get { lock (_locker) return _replacePattern; } }

        /// <include file="../docs/RegexBase.xml" path='extradoc/class[@name="RegexBase"]/methods/method[@name="IsMatch"]/*' />
        public virtual bool IsMatch(string str)
        {
            if (string.IsNullOrWhiteSpace(this.MatchPattern))
                RefreshPatterns();

            return Regex.Match(str, this.MatchPattern).Success;
        }
        
        /// <include file="../docs/RegexBase.xml" path='extradoc/class[@name="RegexBase"]/methods/method[@name="Replace"]/*' />
        public virtual string Replace(string str, string replaceWith = "")
        {
            if (string.IsNullOrWhiteSpace(this.ReplacePattern))
                RefreshPatterns();

            return Regex.Replace(str, this.ReplacePattern, replaceWith);
        }
        
        /// <include file="../docs/RegexBase.xml" path='extradoc/class[@name="RegexBase"]/methods/method[@name="EscapeChars"]/*' />
        public virtual string EscapeChars(string str) => Regex.Escape(str);

        /// <include file="../docs/RegexBase.xml" path='extradoc/class[@name="RegexBase"]/methods/method[@name="RefreshPatterns"]/*' />
        public abstract void RefreshPatterns();
    }
}
