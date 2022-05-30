using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 8, 1, 0, 4, 7 };
            solution(myarray);
        }

        static int solution(int[] statues)
        {
            int returnValue = 0;

            for (int i = 0; i < statues.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (statues[i] < statues[j])
                    {
                        int temp = statues[i];
                        statues[i] = statues[j];
                        statues[j] = temp;
                        i--;
                    }
                }
            }

            for (int i = 0; i < statues.Length - 1; i++)
            {
                returnValue = returnValue + statues[i + 1] - statues[i] - 1;
            }

            return returnValue;
        }
    }
}
