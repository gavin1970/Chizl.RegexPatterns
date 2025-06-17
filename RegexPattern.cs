using Chizl.RegexPatterns.Finance;
using Chizl.RegexPatterns.Network;
using Chizl.RegexPatterns.Personal;
using System;

namespace Chizl.RegexPatterns
{
    enum ClassType
    {
        IPA,
        Money,
    }

    [Serializable]
    public readonly struct RegexPattern
    {
        public static IPA IPA => new IPA();
        public static Money Money => new Money();
        public static Identity Identity => new Identity();
    }
}
