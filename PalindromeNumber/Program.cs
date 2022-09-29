using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(123));
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
        }

        public static bool IsPalindrome(int x)
        {
            List<int> number = new List<int>();

            while (x != 0)
            {
                number.Add(x % 10);
                x = x / 10;
            }

            for (int i = 0; i < number.Count() + 1 / 2; i++)
            {
                if (number[i] != number[number.Count() - i - 1])
                    return false;
            }

            return true;
        }
    }
}
