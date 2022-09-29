using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseKeyFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReformatString("5F3Z-2e-9-w", 4) == "5F3Z-2E9W");
            Console.ReadLine();
        }

        static string ReformatString(string s, int K)
        {
            String returnValue = string.Empty;

            int numCharsGroup = 0;
            int lastDashposition = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '-')
                    numCharsGroup++;

                if(numCharsGroup == K)
                {
                    for(int j = 0; j <= i; j++)
                    {
                        returnValue += s[j];
                    }

                    i++;
                    numCharsGroup = 0;
                    returnValue += '-';
                    lastDashposition = K;
                }
                else if(numCharsGroup < K)
                {
                    if(s[i] == '-' && lastDashposition == 0)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            returnValue += s[j];
                        }

                        returnValue += '-';
                        lastDashposition = i;
                    }
                    else if (s[i] == '-' && lastDashposition > 0)
                    {
                        for (int j = lastDashposition + 1; j <= lastDashposition + numCharsGroup; j++)
                        {
                            returnValue += s[j];
                        }
                        
                    }
                }
            }

            return returnValue;
        }
    }
}
