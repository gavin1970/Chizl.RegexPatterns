using System;
using System.Collections.Generic;
using System.Text;

namespace Chizl.RegexPatterns.models
{
    internal class PatternDefinition
    {
        public int Order { get; set; }
        public Enum Enum { get; set; }
        public string Pattern { get; set; }
        public string Definition { get; set; }
    }
}
