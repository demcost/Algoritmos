using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

            Console.ReadLine();

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }


        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int count = 0;
            string aux = string.Empty;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if(ar[i] > 0 && ar[j] > 0 && ar[i] == ar[j])
                    {
                        ar[i] = -1;
                        ar[j] = -1;
                        count++;
                        break;
                    }
                }
            }

            return count;

        }
    }
}
