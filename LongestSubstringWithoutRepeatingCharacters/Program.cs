using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine( lengthOfLongestSubstring("dvdf") == 3);
            Console.WriteLine(lengthOfLongestSubstring(" ") == 1);
            Console.WriteLine(lengthOfLongestSubstring("au") == 2);
            Console.WriteLine(lengthOfLongestSubstring("aab") == 2);
            Console.WriteLine(lengthOfLongestSubstring("abcabcbb") == 3);
            Console.WriteLine(lengthOfLongestSubstring("bbbbb") == 1);
            Console.WriteLine(lengthOfLongestSubstring("pwwkew") == 3);
            Console.WriteLine(lengthOfLongestSubstring("cdd") == 2);
        }

        static int lengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
                return 0;

            int longestSubstring = 0;

            for (int i = 0; i < s.Length; i++)
            {
                bool[] chars = new bool[256];

                for (int j = i; j < s.Length; j++)
                {
                    if (chars[s[j]])
                        break;
                    else
                    {
                        longestSubstring = j - i + 1 > longestSubstring ? j - i + 1: longestSubstring;
                        chars[s[j]] = true;
                    }
                        
                }
            }

            return longestSubstring;
        }
    }
}