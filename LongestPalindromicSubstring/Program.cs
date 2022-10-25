using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
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
            Console.ReadLine();
            Console.WriteLine(LongestPalindrome(text) == "abcda");
            Console.ReadLine();
        }

        public static string LongestPalindrome(string s)
        {
            string returnValue = string.Empty;

            if (s.Length == 1)
                return s;

            if(s.Length == 2 && s[0] != s[1])
            {
                return s[0].ToString();
            }
            
            for(int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    string aux = string.Empty;

                    if (s[i] == s[j])
                    {
                        //check if palindrome
                        int a = i;
                        int b = j;

                        while (i <= b)
                        {
                            if (s[b] != s[a])
                            {
                                aux = String.Empty;
                                break;
                            }
                            else
                            {
                                aux += s[a];
                            }

                            b--;
                            a++;
                        }


                        if (returnValue == string.Empty)
                        {
                            returnValue = aux;
                        }
                        else
                        {
                            if (returnValue.Length < aux.Length)
                            {
                                returnValue = aux;
                            }
                        }
                    }
                }
            }

            if(returnValue == String.Empty)
                returnValue = s[0].ToString();

            return returnValue;
        }
    }
}
