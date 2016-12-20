using System;

namespace CSharp_new_features
{
    public class AutoProperty
    {
        public class Customer
        {
            public string First { get; set; } = "Jane";
            public string Last { get; set; } = "Doe";
        }

        public class Customer2
        {
            public string Name { get; } = "HelloWrold";

            public Customer2(string first, string last)
            {
                Name = first + " " + last;
            }
        }
    }
}
