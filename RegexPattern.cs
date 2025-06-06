using Chizl.RegexPatterns.Finance;
using Chizl.RegexPatterns.Network;
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
    }
}
