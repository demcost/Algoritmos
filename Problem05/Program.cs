using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int totalPositive = 0;
            int totalNegative = 0;
            int totalZero = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] > 0)
                    totalPositive++;
                else if (arr[i] < 0)
                    totalNegative++;
                else if (arr[i] == 0)
                    totalZero++;
            }

            Console.WriteLine("{0:N6}", Decimal.Divide(totalPositive, arr.Count()));
            Console.WriteLine("{0:N6}", Decimal.Divide(totalNegative, arr.Count()));
            Console.WriteLine("{0:N6}", Decimal.Divide(totalZero, arr.Count()));
        }

    }
}
