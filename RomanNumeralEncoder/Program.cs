using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralEncoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string Solution(int n)
        {
            string returnValue = string.Empty;

            int nAux = n;
            int count = 1;

            while(nAux > 0)
            {
                if(nAux % 10 < 9)
                {

                }
                else
                {

                }

                nAux = (nAux % 10) * count;
                count *= 10;
            }



            switch (value)
            {
                case 1: 
                    returnValue += "I";
                    break;
                case 5:
                    returnValue += "V";
                    break;
                case 10:
                    returnValue += "X";
                    break;
                case 50:
                    returnValue += "L";
                    break;
                case 100:
                    returnValue += "C";
                    break;
                case 500:
                    returnValue += "D";
                    break;
                case 1000:
                    returnValue += "M";
                    break;
                default:
                    break;
            }
        }
    }
}
