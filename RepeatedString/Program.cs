using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            repeatedString("gfcaaaecbg", 547602);

        }

        public static long repeatedString(string s, long n)
        {
            long stringlength = s.Length;
            long returnValue = 0;
            int countA = 0;

            if (stringlength == 1 && s == "a")
            {
                returnValue = n;
            }
            else
            {
                for (int i = 0; i < stringlength; i++)
                {
                    if (s[i] == 'a')
                    {
                        countA++;
                    }
                }

                if (countA == 0)
                    returnValue = 0;
                else
                {
                    returnValue = ((n / stringlength) * countA);
                    
                    for(int i = 0; i < n % stringlength; i++)
                    {
                        if (s[i] == 'a')
                        {
                            returnValue++;
                        }
                    }
                }
                    
            }
            return returnValue;
        }
    }
}
