using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace CSharp_new_features
{
    class CollectionInitializers
    {
        private static void DictionaryInitializer()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int> {
                ["Year"] = 2015,
                ["Month"] = 03,
                ["Day"] = 15
            };
        }
    }
}
