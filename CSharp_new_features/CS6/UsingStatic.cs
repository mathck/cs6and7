using System;
using static System.Console;
using static System.Math;
using static System.String;

namespace CSharp_new_features
{
    class UsingStatic
    {
        public static void WritingLines()
        {
            Console.WriteLine("The C# 5 way");

            WriteLine("Just call the static method directly");
        }

        public static void MathOperations()
        {
            double a = 1, b = 2, c;

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            c = Sqrt(Pow(a, 2) + Pow(b, 2));
        }

        public static void StringOperations()
        {
            var cs5_a = string.IsNullOrEmpty("");
            var cs5_b = string.IsNullOrWhiteSpace("");

            var cs6_a = IsNullOrEmpty("");
            var cs6_b = IsNullOrWhiteSpace("");
        }
    }
}
