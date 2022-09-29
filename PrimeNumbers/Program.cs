using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (isPrime(11))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            // Check if n=2 or n=3
            if (n == 2 || n == 3)
                return true;

            // Check whether n is divisible by 2 or 3
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            // Check from 5 to square root of n
            // Iterate i by (i+6)
            for (int i = 5; i <= Math.Sqrt(n); i = i + 6)
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;

            return true;
        }
    }
}
