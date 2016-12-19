using NUnit.Framework;
using System;

namespace CSharp_new_features
{
    class LocalFunctions
    {
        void level1()
        {
            void level2()
            {
                void level3()
                {
                    int level4()
                    {
                        return 4;
                        // ...
                    }

                    var result = level4();
                    level1();
                }
            }
        }

        /// 1, 1, 2, 3, 5, 8, 13, ...
        public int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException("Less negativity please!", nameof(x));
                return Fib(x).current;

            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                var (p, pp) = Fib(i - 1);
                return (p + pp, p);
            }
        }
    }
}
