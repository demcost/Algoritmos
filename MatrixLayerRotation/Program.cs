using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLayerRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>()
            {
                new List<int>(){ 1, 2, 3, 4},
                new List<int>(){12, 1, 2, 5},
                new List<int>(){11, 4, 3, 6},
                new List<int>(){10, 9, 8, 7}
            };

            matrixRotation(matrix, 2);
        }

        static List<List<int>> matrixRotation(List<List<int>> matrix, int rotationFactor)
        {
            List<List<int>> returnList = matrix; 

            int numColumns = matrix.Count();
            int numRows = matrix[0].Count();

            int numLayers;
            if (numColumns > numRows)
                numLayers = numRows / 2;
            else
                numLayers = numColumns / 2;

            for (int a = 0; a < numLayers; a++) //move between each layer
            {
                List<int> tempArr = new List<int>();

                for (int j = a; j < numColumns - a - 1; j++)
                {
                    tempArr.Add(matrix[a][j]); // row fixed, col increase
                }

                for (int i = a; i < numRows - a - 1; i++)
                {
                    tempArr.Add(matrix[i][numColumns - a - 1]); // column fixed, row increase
                }

                for (int j = numColumns - a - 1; j >= a; j--)
                {
                    tempArr.Add(matrix[numRows - a - 1][j]); // row fixed, col decrease
                }

                for (int i = numRows - a - 2; i > a; i--)
                {
                    tempArr.Add(matrix[i][a]); //column fixed, row decrease
                }

                for (int i = 0; i < rotationFactor; i++)
                {
                    int temp = tempArr[0];

                    for (int j = 1 ; j < tempArr.Count; j++)
                    {
                        tempArr[j - 1] = tempArr[j];
                    }

                    tempArr[tempArr.Count - 1] = temp;
                }

                int indexArr = 0;

                for (int j = a; j < numColumns - a - 1; j++)
                {
                    returnList[a][j] = tempArr[indexArr]; // row fixed, col increase

                    indexArr++;
                }

                for (int i = a; i < numRows - a - 1; i++)
                {
                    returnList[i][numColumns - a - 1] = tempArr[indexArr]; // column fixed, row increase

                    indexArr++;
                }

                for (int j = numColumns - a - 1; j >= a; j--)
                {
                    returnList[numRows - a - 1][j] = tempArr[indexArr]; // row fixed, col decrease

                    indexArr++;
                }

                for (int i = numRows - a - 2; i > a; i--)
                {
                    returnList[i][a] = tempArr[indexArr]; //column fixed, row decrease

                    indexArr++;
                }
            }

            return returnList;

        }
    }
}
