using System;

namespace SortAlgorithms
{
    public static class SelectionSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[i]) == -1)
                    {
                        //swap
                        T aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;
        }
    }
}
