using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>() { 5, 3, 1, 2, 4 };
            findMedian(lista);

            Console.ReadLine();
        }

        public static int findMedian(List<int> arr)
        {
            arr.Sort();

            int index = arr.Count() / 2;

            int median = arr[index];

            return median;
        }
    }


}
