///####################### IN PROGRESS ###################################
//using System;
//using System.Linq;
//using System.Collections.Generic;
//using Chizl.RegexPatterns.models;
//using Chizl.RegexPatterns.Personal;

//namespace Chizl.RegexPatterns.Personal
//{
//    internal static class DataList
//    {
//        static readonly Dictionary<char, bool> _charDict = new Dictionary<char, bool>() 
//        { 
//            { '(', true }, { ')', false }, { '[', true }, { ']', false }, 
//            { '{', true }, { '}', false }, { '|', false } 
//        };
//        static readonly List<PatternDefinition> _patternDefinitions = new List<PatternDefinition>();

//        static DataList()
//        {

//        }

//        public static void GetMatchingDescriptions()
//        {
//            foreach(Identify e in Enum.GetValues(typeof(Identify)))
//                GetPatternDefs(e);
//        }

//        private static void Add(Identify id, string pattern, string definition)
//        {
//            var order = _patternDefinitions.Count();
//            _patternDefinitions.Add(new PatternDefinition()
//            {
//                Order = order,
//                Enum = id,
//                Pattern = pattern,
//                Definition = definition
//            });
//        }

//        /// <summary>
//        /// ^((\+1\s)?((\([0-9]{3}\)\s)|[0-9\-]{4}))([0-9]{3})-([0-9]{4})$
//        /// </summary>
//        /// <param name="match"></param>
//        private static void GetPatternDefs(Identify identify)
//        {
//            var match = identify.MatchPattern();

//            var charLocations = match.Select((character, index) => new { character, index })
//                                        .OrderBy(x => x.index)
//                                        .Where(x => _charDict.Keys.Contains(x.character))
//                                        //.Select(x => (x.index, x.character))
//                                        .ToDictionary(x => new { x.index, x.character });

//            foreach(var cl in charLocations)
//            {
//                var pattern = "";
//                var definition = "";


//                Add(identify, pattern, definition);
//            }

//            ///// Another way to store it, but using Tuple.  I don't see any performace increase by using it, 
//            ///// but when I'm debugging it looks like more garbage, than the way already used.
//            //var charLocations = match.Select((character, index) => new { character, index })
//            //                         .OrderBy(x => x.index)
//            //                         .Where(x => keys.Contains(x.character))
//            //                         .ToDictionary(x => Tuple.Create(x.index, x.character));
//        }

//        ///// <summary>
//        ///// Inital way to pull, but ended up going with ToDictionary
//        ///// </summary>
//        ///// <param name="match"></param>
//        ///// <param name="c"></param>
//        ///// <returns></returns>
//        //static int[] GetCharLocations(string match, char c) => match.Select((character, index) => new { character, index })
//        //                                                            .Where(x => x.character == c)
//        //                                                            .Select(x => x.index)
//        //                                                            .ToArray();
//    }
//}
