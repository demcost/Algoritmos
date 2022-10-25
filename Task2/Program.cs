using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[] { "100", "110", "010", "011", "100" };
            Console.WriteLine(solution(cars) == new int[] { 2, 3, 2, 1, 2 });
        }

        public static int[] solution(string[] cars)
        {
            int[] arrayresult = new int[cars.Length];

            //iterate through each car
            for(int i = 0; i < cars.Length; i++)
            {
                //compare with each other cars
                for (int j = i + 1; j < cars.Length; j++)
                {
                    int numDifferences = 0;
                    //compare each feature from two cars
                    for (int feature = 0; feature < cars[i].Length; feature++)
                    {
                        if (cars[i][feature] != cars[j][feature])
                        {
                            numDifferences++;
                        }
                    }

                    if (numDifferences == 0 || numDifferences == 1)
                    {
                        arrayresult[i] += 1;
                        arrayresult[j] += 1;
                    }
                }
            }

            return arrayresult;
        }
    }
}
