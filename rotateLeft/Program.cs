using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotateLeft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> c = "1 2 3 4 5".Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();
            rotLeft(c, 6);
        }

        public static List<int> rotLeft(List<int> a, int d)
        {
            int n = a.Count;

            int[] returnValue = new int[n];

            while(d > n)
            {
                d = d - n;
            }

            for (int i = 0; i < n; i++)
            {
                int newIndex =  i - d;

                if (newIndex < 0)
                    newIndex = n + newIndex;

                returnValue[newIndex] = a[i];
            }

            return returnValue.ToList<int>();
        }
    }


}
