using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newYearChaos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 2;

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = 5;

                List<int> q = new List<int>() { 2, 1, 5, 3, 4, };

                minimumBribes(q);
            }
        }

        public static void minimumBribes(List<int> q)
        {
            if (q != null && q.Count > 0)
            {
                int countBribes = 0;

                for (int i = 0; i < q.Count; i++)
                {
                    int numbribes = q[i] - (i + 1);

                    if (numbribes > 0)
                    {
                        countBribes = countBribes + numbribes;
                    }

                    if(countBribes > 2)
                    {
                        Console.WriteLine(countBribes);
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                }

                

            }

        }

    }
}
