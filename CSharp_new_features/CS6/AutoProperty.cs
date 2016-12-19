using System;

namespace CSharp_new_features
{
    class AutoProperty
    {
        public class Customer
        {
            public string First { get; set; } = "Jane";
            public string Last { get; set; } = "Doe";
        }

        public class Customer2
        {
            public string Name { get; }
            public Customer2(string first, string last)
            {
                Name = first + " " + last;
            }
        }
    }
}
