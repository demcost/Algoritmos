using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestStringComposedOfBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            solution("aabacbba");

        }

        public static int solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.7 (Mono 6.12)

            

            int result = 0;

            for (int i = 0; i < S.Length; i++)
            {
                bool isBlock = false;
                int count = 0;

                for (int j = i + 1; j < S.Length; j++)
                {
                    if (S[i] == S[j])
                    {
                        count++;

                        if(count > 1)
                        {
                            isBlock = true;
                        }
                    }
                }

                result += count;
            }



            return result;
        }
    }
}
