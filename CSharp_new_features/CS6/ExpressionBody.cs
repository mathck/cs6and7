using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace CSharp_new_features
{
    class ExpressionBody
    {
        public override string ToString() => $"Value : {15}";

        public Student this[string name] => new Student { Name = name };
    }
}
