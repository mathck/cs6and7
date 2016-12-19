using NUnit.Framework;
using System;

namespace CSharp_new_features
{
    class LocalFunctions
    {
        static void TestMethodOld()
        {
            // Arrange
            var theBestStringEver = "I'am the best!";
            var theBestStringEver2 = "No!!";
            var theBestStringEver3 = "wow";
            var theBestStringEver4 = "muuuuuuh";

            // Act
            var result = string.IsNullOrEmpty(theBestStringEver);

            // Assert
            Assert.IsFalse(result);
        }

        static void TestMethodNew()
        {
            void arrange() {
                var theBestStringEver = "I'am the best!";
                var theBestStringEver2 = "No!!";
                var theBestStringEver3 = "wow";
                var theBestStringEver4 = "muuuuuuh";
            }

            void act()
            {
                var result = string.IsNullOrEmpty(theBestStringEver);
            }

            void assert()
            {
                Assert.IsFalse(result);
            }
        }

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
