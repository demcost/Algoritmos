using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    public static class BinarySearch
    {
        public static bool Search<T>(T[] array, T targetElement) where T : IComparable
        {
            bool elementFound = false;

            int midIndex = 0;

            if (array.Length > 0)
            {
                midIndex = array.Length / 2; 

                // Um elemento apenas
                if(midIndex == 0 && targetElement.CompareTo(array[midIndex]) != 0)
                {
                    return elementFound;
                }

                if (targetElement.CompareTo(array[midIndex]) == 0)
                {
                    elementFound = true;
                    return elementFound;
                }
                else if (targetElement.CompareTo(array[midIndex]) > 0)
                {
                    int lastIndex = array.Length;
                    int newarrayLength = lastIndex - midIndex;

                    T[] newarray = new T[newarrayLength];

                    Array.Copy(array, midIndex, newarray, 0, newarrayLength);

                    elementFound = Search(newarray, targetElement);  
                }
                else if (targetElement.CompareTo(array[midIndex]) < 0)
                {
                    int firstIndex = 0;
                    int newarrayLength = midIndex - firstIndex;

                    T[] newarray = new T[newarrayLength];

                    Array.Copy(array, firstIndex, newarray, 0, newarrayLength);

                    elementFound = Search(newarray, targetElement);
                }
            }

            return elementFound;
        }

    }
}