using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);
            int[] result2 = TwoSumOther(nums, target);

            Console.WriteLine(result.ToString());
            Console.WriteLine(result2.ToString());
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] returnArray = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        returnArray.SetValue(i, 0);
                        returnArray.SetValue(j, 1);

                        return returnArray;
                    }
                }
            }



            return returnArray;
        }


        public static int[] TwoSumOther(int[] nums, int target)
        {
            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (numsDictionary.TryGetValue(target - num, out int index))
                {
                    return new[] { index, i };
                }

                numsDictionary[num] = i;
            }

            return new int[] { -1, -1 };

        }
    }
}