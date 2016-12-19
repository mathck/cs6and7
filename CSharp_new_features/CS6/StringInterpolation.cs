using System;

namespace CSharp_new_features
{
    class StringInterpolation
    {
        public static void StringInterpolationEnhancements()
        {
            string name = "Adil";
            string content = "blog";
            DateTime date = new DateTime();
            int versionYear = 2016;

            // C# 5
            Console.WriteLine(string.Format("This {3} was written by {0} on {1} using Visual Studio {2}", name, date, versionYear, content));

            // C# 6
            Console.WriteLine($"This {content} was written by {name} on {date} using Visual Studio {versionYear}");

            Console.WriteLine($@"This is line number 1
                                My name is {name}
                                today is {date}");
        }
    }
}
