using System;

namespace CSharp_new_features
{
    class AutoProperty
    {
        public class MoreEnhancements
        {
            // A getter only property with readyonly backing field
            public int DemoInt { get; }

            // An auto property intialized with default value
            public string DemoString { get; set; } = "Demo";

            public MoreEnhancements()
            {
                // Assignment in constructor for getter only field behaves like readonly field
                this.DemoInt = 100;
            }
        }
    }
}
