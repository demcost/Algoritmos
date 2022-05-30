using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flippingMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>()
            {
                new List<int>(){ 112, 42,   83, 119 },
                new List<int>(){ 56, 125,   56,  49 },
                new List<int>(){ 15,  78,  101,  43 },
                new List<int>(){ 62,  98,  114, 108 },
            };

            int result = flippingMatrix(matrix);

        }

        public static int flippingMatrix(List<List<int>> matrix)
        {
            int totalRows = matrix.Count;
            int totalColumns = matrix[0].Count;
            int returnValue = 0;

            for (int i = 0; i <= (totalRows - 1) / 2 ; i++)
            {
                for (int j = 0; j <= (totalColumns - 1) / 2; j++)
                {
                    List<int> tempList = new List<int>();

                    tempList.Add(matrix[i][0 + j]);
                    tempList.Add(matrix[i][totalColumns - 1 - j]);
                    tempList.Add(matrix[totalRows - 1 - i][0 + j]);
                    tempList.Add(matrix[totalRows - 1 - i][totalColumns - 1 - j]);

                    returnValue = returnValue + tempList.Max();
                }
            }

            return returnValue;
        }
    }
}
