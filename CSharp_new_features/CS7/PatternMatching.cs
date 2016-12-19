using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp_new_features.CS7
{
    class PatternMatching
    {
        void newWay()
        {
            // Example 1   
            var myData = "Custom Data";
            var myData2 = myData is string ? "String" : "Not a string";
            var myData3 = myData is string a ? a : "Not a String";

            // Example 2
            var x = 10;
            dynamic y = 0b1001;
            var sum = y is int? $"{y * x}" : "Invalid data";
        }

        class Shape
        {

        }

        class Circle : Shape
        {
            public int Radius { get; set; }
        }

        class Rectangle : Shape
        {
            public int Length { get; set; }
            public int Height { get; set; }
        }

        void switchCase()
        {
            var shape = new Shape();

            switch (shape)
            {
                case Circle c:
                    WriteLine($"circle with radius {c.Radius}");
                    break;
                case Rectangle s when (s.Length == s.Height):
                    WriteLine($"{s.Length} x {s.Height} square");
                    break;
                case Rectangle r:
                    WriteLine($"{r.Length} x {r.Height} rectangle");
                    break;
                default:
                    WriteLine("<unknown shape>");
                    break;
                case null:
                    throw new ArgumentNullException(nameof(shape));
            }
        }
    }
}
