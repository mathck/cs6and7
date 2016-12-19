using System;
using System.Collections.Generic;

namespace CSharp_new_features
{
    class IndexInitializers
    {
        void sample()
        {
            var numbers = new Dictionary<int, string>
            {
                [7] = "seven",
                [9] = "nine",
                [13] = "thirteen"
            };
        }
    }
}
