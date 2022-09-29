using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findZigZagSequence
{
    internal class ZigZag
    {
        public static void findZigZagSequence(int[] a, int n)
        {
            Array.Sort(a);
            int mid = (n + 1) / 2;
            int temp = a[mid];
            a[mid] = a[n - 1];
            a[n - 1] = temp;

            int st = a[mid + 1]; // 
            int ed = a[n - 1];
            while (st <= ed)
            {
                temp = a[st];
                a[st] = a[ed];
                a[ed] = temp;
                st = st + 1;
                ed = ed + 1;
            }
            for (int i = 0; i < n; i++)
            {
                if (i > 0) Console.Write(" ");
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }

    }
}
