using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple3or5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(4 % 5);
            Console.Read();

        }

        public static int Solution(int value)
        {
            // Magic Happens
            int returnValue = 0;

            for (int i = value - 1 ; i >= 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    returnValue = returnValue + i;
                }
            }

            return returnValue;
        }
    }
}
