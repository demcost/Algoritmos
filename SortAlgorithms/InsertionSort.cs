using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    public class InsertionSort
    {
        static int counter = 0;

        public static T[] Sort<T>(T[] array) where T: IComparable
        {
            Debug.WriteLine(counter++);

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) > 0)
                {
                    T aux = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = aux;

                    Sort(array);
                }
            }

            

            return array;
        }

        public static T[] SortFromBook<T>(T[] array) where T : IComparable
        {
            Debug.WriteLine(counter++);

            for (int i = 1; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    T aux = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = aux;

                    j--;
                }
            }

            return array;
        }
    }
}
