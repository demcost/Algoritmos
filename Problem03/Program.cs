﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

    class Result
    {

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>() { 0, 0 };

            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                    result[0] = result[0] + 1;
                else if (a[i] < b[i])
                    result[1] = result[1] + 1;
            }

            return result;
        }

    }
}
