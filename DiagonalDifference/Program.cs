using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> a = new List<List<int>>();

            a.Add(new List<int>() { 11, 2, 4 });
            a.Add(new List<int>() { 4, 5, 6 });
            a.Add(new List<int>() { 10, 8, - 12 });

            diagonalDifference(a);

        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int lineIndex = 0;
            int columnIndex = 0;
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int returnValue = 0;

            foreach (List<int> line in arr)
            {
                foreach (int element in line)
                {
                    if (lineIndex == columnIndex)
                        primaryDiagonal = primaryDiagonal + element;

                    if (lineIndex + columnIndex == line.Count - 1)
                        secondaryDiagonal = secondaryDiagonal + element;

                    columnIndex++;
                }

                columnIndex = 0;

                lineIndex++;
            }

            returnValue = primaryDiagonal - secondaryDiagonal;

            if (returnValue < 0)
                returnValue = returnValue * -1;

            return returnValue;
        }
    }
}
