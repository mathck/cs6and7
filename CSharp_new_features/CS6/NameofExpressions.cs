using System;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace CSharp_new_features
{
    class NameofExpressions
    {
        void sample()
        {
            Student x = new Student();

            // ...

            if (x == null)
                throw new ArgumentNullException(nameof(x));
        }
    }
}
