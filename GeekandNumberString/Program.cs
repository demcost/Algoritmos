using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekandNumberString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(minLength("12213", 5).ToString());
            Console.WriteLine(minLength("1350", 4).ToString());
            Console.WriteLine(minLength("123578", 6).ToString());
            Console.WriteLine(minLength("122190", 6).ToString());
            Console.WriteLine(minLength("8734344344334521", 16).ToString());
        }

        private static int minLength(string s, int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                int left = Int32.Parse(s[0].ToString());
                int right = Int32.Parse(s[1].ToString());

                if ((left == right - 1) || (left == right + 1))
                    return 0;

                if ((left == 9 && right == 0) || (left == 0 && right == 9))
                {
                    return 0;
                }

                return 2;
            }
            else if (n > 2)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    int left = Int32.Parse(s[i].ToString());
                    int right = Int32.Parse(s[i + 1].ToString());

                    if ((left == right - 1) || (left == right + 1))
                    {
                        s = s.Remove(i, 2);
                        return minLength(s, s.Length);
                    }

                    if ((left == 9 && right == 0) || (left == 0 && right == 9))
                    {
                        s = s.Remove(i, 2);
                        return minLength(s, s.Length);
                    }
                }

                return s.Length;
            }

            return 0;
        }
    }
}
