using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "PAYPALISHIRING";
            Console.WriteLine(Convert(text, 4) == "PINALSIGYAHRPI");
            Console.WriteLine(Convert(text, 3) == "PAHNAPLSIIGYIR");
        }

        public static string Convert(string s, int numRows)
        {
            List<char[]> rows = new List<char[]>();

            //create arrays
            for (int i = 0; i < numRows; i++)
            {
                rows.Add(new char[s.Length]);
            }


            int posIndex = 0;
            int rowIndex = 0;
            bool increase = true;

            //fill arrays
            for(int x = 0; x < s.Length; x++)
            {
                rows[rowIndex][posIndex] = s[x];

                if (increase)
                    rowIndex++;
                else
                {
                    posIndex++;
                    rowIndex--;
                }
                    

                
                if (increase && rowIndex >= numRows) //superior limit
                {
                    rowIndex = rowIndex - 2;
                    posIndex++;
                    increase = false;
                }
                    
                
                if(!increase && rowIndex < 0) //inferior limit
                {
                    rowIndex = 1;
                    posIndex--;
                    increase = true;
                }
                    
            }

            string returnValue = string.Empty;

            for (int i = 0; i < numRows; i++)
            {
                returnValue += new string(rows[i]).Replace("\0",string.Empty);
            }

            return returnValue;
        }
    }
}
