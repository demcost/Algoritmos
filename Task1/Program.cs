using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(14) == 19);
            Console.WriteLine(solution(10) == 11);
        }

        public static int solution(int N)
        {
            int returnValue = 0;

            int sumDigitsN = 0;
            int temp = N;
            //calcule digits
            while(temp % 10 > 0)
            {
                sumDigitsN += temp % 10;
                temp = temp / 10;
            }

            if (temp == 10)
                sumDigitsN = 1;

            //calcule tiwice as sum of digits
            int twiceAsSumDigitsN = 2 * sumDigitsN;
            
            int sumDigitsNewN = 0;

            int NextValue = N;

            do
            {
                NextValue = NextValue + 1;
                temp = NextValue;
                sumDigitsNewN = 0;

                while (temp % 10 > 0)
                {
                    sumDigitsNewN += temp % 10;
                    temp = temp / 10;
                }
            }
            while (twiceAsSumDigitsN != sumDigitsNewN);

            returnValue = NextValue;

            return returnValue; 
        }
    }
}
