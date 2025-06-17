using System.Runtime.CompilerServices;

namespace Chizl.RegexPatterns.Personal
{
    //public sealed class Money : RegexBase
    public sealed class Identity : RegexBase
    {
        /// <summary>
        /// Insurance that it can only be initialized from within this library.
        /// </summary>
        internal Identity() { }

        #region Public Methods
        public void SetIdentify(Identify identify)
        {
            _matchPattern = identify.MatchPattern();
            _replacePattern = identify.ReplacePattern();
        }
        #endregion

        #region Public Overrides
        public string PatternBreakdown(Identify idenify) => idenify.PatternBreakDown();
        public bool IsMatch(Identify idenify, string str)
        {
            SetIdentify(idenify);
            return base.IsMatch(str);
        }
        public string Replace(Identify idenify, string str, string replaceWith = "")
        {
            SetIdentify(idenify);
            return base.Replace(str, replaceWith);
        }
        [Discardable]
        public override void RefreshPatterns() {}
        #endregion
    }
}
