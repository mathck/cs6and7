using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace CSharp_new_features
{
    class CollectionInitializers
    {
        void DictionaryInitializer()
        {
            var list = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            var dictionary = new Dictionary<string, int> {
                ["Year"] = 2015,
                ["Month"] = 03,
                ["Day"] = 15
            };

            var numbers = new Dictionary<int, string>
            {
                [7] = "seven",
                [9] = "nine",
                [13] = "thirteen"
            };
        }
    }
}
