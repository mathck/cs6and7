using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace CSharp_new_features
{
    public class NameofExpressions
    {
        public static string sample()
        {
            Student myStudent = new Student();

            // ...

            return nameof(myStudent);
        }
    }
}
