using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue]  by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int FindGcd(int a, int b)
        {
            int gcd = 0;
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if ((a == int.MinValue) || (b == int.MinValue))
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }
            else
            {
                while (b != 0)
                {
                    var temp = b;
                    b = a % b;
                    a = temp;
                }

                if (a < 0)
                {
                    gcd = a * -1;
                }
                else
                {
                    gcd = a;
                }
            }

            return gcd;
        }
    }
}
