using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class BubbleSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            int swapCounter = -1; // just to start code execution criteria

            while (swapCounter != 0)
            {
                swapCounter = 0;

                for (int i = 1; i < array.Length; i++)
                {
                    if(array[i - 1].CompareTo(array[i]) > 0)
                    {
                        //swap

                        T aux = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = aux;

                        swapCounter++;
                    }
                }
            }

            return array;
        }
    }
}
