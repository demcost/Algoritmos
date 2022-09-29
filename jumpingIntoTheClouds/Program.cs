using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumpingIntoTheClouds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());
            int n = 7;

            //List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            List<int> c = "0 1 0 0 0 1 0".Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = Result.jumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }

    class Result
    {

        /*
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */

        public static int jumpingOnClouds(List<int> c)
        {
            int pathALength = 0;
            int pathBLength = 0;
            int index = 0;

            if (c.Count == 1)
                return 0;

            //path A
            if (c.Count >= 2 && c[index + 1] == 0)
                pathALength += 1 + jumpingOnClouds(c.GetRange(index + 1, c.Count() - 1));
    
            //path B
            if (c.Count >= 3 && c[index + 2] == 0)
                pathBLength += 1 + jumpingOnClouds(c.GetRange(index + 2, c.Count() - 2));

            if (pathALength == 0)
                return pathBLength;

            if (pathBLength == 0)
                return pathALength;

            if (pathALength > pathBLength)
                return pathBLength;

            return pathALength;

        }

    }
}
