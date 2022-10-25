using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstringV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "babad";
            Console.WriteLine(LongestPalindrome(text) == "bab");
            text = "cbbd";
            Console.WriteLine(LongestPalindrome(text) == "bb");
            text = "ccc";
            Console.WriteLine(LongestPalindrome(text) == "ccc");
            text = "abb";
            Console.WriteLine(LongestPalindrome(text) == "bb");
            Console.ReadLine();
        }

        public static string LongestPalindrome(string s)
        {
            string returnValue = string.Empty;

            //s.Length == 1
            if(s.Length == 1)
            {
                return s;
            }

            //s.Length == 2
            if (s.Length == 2)
            {
                if (s[0] != s[1])
                {
                    return s[0].ToString();
                }
                else
                {
                    return s;
                }
            }

            for (int sChar = 0; sChar < s.Length; sChar++)
            {
                int inferiorLimit = sChar;
                int superiorLimit = sChar;

                //even

                while (inferiorLimit >= 0 && superiorLimit <= s.Length - 1 && s[inferiorLimit] == s[superiorLimit])
                {
                    int size = superiorLimit - inferiorLimit + 1;

                    if (size > returnValue.Length)
                    {
                        if (inferiorLimit < 0)
                            inferiorLimit = 0;

                        if (superiorLimit > s.Length - 1)
                            superiorLimit = s.Length - 1;

                        returnValue = String.Empty;

                        for (int a = inferiorLimit; a <= superiorLimit; a++)
                        {
                            returnValue += s[a];
                        }
                    }

                    inferiorLimit--;
                    superiorLimit++;
                }

                superiorLimit = sChar + 1;


                //odd

                inferiorLimit = sChar;
                superiorLimit = sChar + 1;


                while (inferiorLimit >= 0 && superiorLimit <= s.Length - 1 && s[inferiorLimit] == s[superiorLimit])
                {
                    int size = superiorLimit - inferiorLimit + 1;

                    if (size > returnValue.Length)
                    {
                        if (inferiorLimit < 0)
                            inferiorLimit = 0;

                        if (superiorLimit > s.Length - 1)
                            superiorLimit = s.Length - 1;

                        returnValue = String.Empty;

                        for (int a = inferiorLimit; a <= superiorLimit; a++)
                        {
                            returnValue += s[a];
                        }
                    }

                    inferiorLimit--;
                    superiorLimit++;
                }


            }

            return returnValue;
        }
    }
}
