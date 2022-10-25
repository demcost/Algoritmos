using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution("acbcbba");
        }

        public static int solution(string S)
        {
            int count = 0;

            int[] array = new int[256];

            if(S.Length % 2 > 0)
            {
                //count each letter
                for (int i = 0; i < S.Length; i++)
                {
                    array[S[i]]++;
                }

                for (int i = 0; i < 256; i++)
                {
                    if(array[i] % 2 > 0)
                    {
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < S.Length; i++)
                {
                    array[S[i]]++;
                }

                for (int i = 0; i < 256; i++)
                {
                    if (array[i] % 2 > 0)
                    {
                        count++;
                    }
                }
            }


            return count;
        }
    }
}
