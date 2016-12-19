using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_new_features.CS7
{
    class PatternMatching
    {
        void oldWay()
        {
            //Example 1   
            var myData = "Custom Data";
            var myData2 = myData is string ? "String" : "Not a string";
            var myData3 = myData is string a ? a : "Not a String";

            //Example 2
            var x = 10;
            dynamic y = 0b1001;
            var sum = y is int? $"{y * x}" : "Invalid data";
        }

        // TODO need more!
    }
}
