using System;
using System.Collections.Generic;

namespace FindAllDuplicatesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {4, 3, 2, 7, 8, 2, 3, 1};

            int[] returnedArray = (int[])FindDuplicates(nums);
        }

        public static IList<int> FindDuplicates(int[] nums)
        {
            List<int> returnArray = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        returnArray.Add(nums[i]);
                }
            }

            return returnArray.ToArray(); 
        }
    }
}
