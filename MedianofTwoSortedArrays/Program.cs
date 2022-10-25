using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianofTwoSortedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 });
            FindMedianSortedArrays(new int[] { 1, 2 }, new int[] { 3, 4 });

        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            double returnValue;

            double[] resultArray = new double[nums1.Length + nums2.Length];

            int indice1 = 0;
            int indice2 = 0;
            int i = 0;
            while(i < resultArray.Length)
            {
                if (indice1 < nums1.Length && indice2 < nums2.Length)
                {
                    if (nums1[indice1] <= nums2[indice2])
                    {
                        resultArray[i] = nums1[indice1];
                        indice1++;
                        i++;
                    }
                }

                if (indice1 < nums1.Length && indice2 < nums2.Length)
                {

                    if (nums1[indice1] > nums2[indice2])
                    {
                        resultArray[i] = nums2[indice2];
                        indice2++;
                        i++;
                    }
                }


                else if (indice1 > nums1.Length - 1)
                {
                    resultArray[i] = nums2[indice2];
                    indice2++;
                    i++;
                }
                else if (indice2 > nums2.Length - 1)
                {
                    resultArray[i] = nums1[indice1];
                    indice1++;
                    i++;
                }
                
            }


            if ((nums1.Length + nums2.Length) % 2 > 0)
            {
                int elementResult = (nums1.Length + nums2.Length) / 2 + (nums1.Length + nums2.Length) % 2;
                returnValue = resultArray[elementResult - 1];
            }
            else
            {
                int elementResult1 = (nums1.Length + nums2.Length) / 2;
                int elementResult2 = (nums1.Length + nums2.Length) / 2 + 1;
                returnValue = (resultArray[elementResult1 - 1] + resultArray[elementResult2 - 1]) / 2;
            }

            return returnValue;
        }
    }
}
