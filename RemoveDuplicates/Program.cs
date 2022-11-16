using System;

namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicates(new int[] { 1, 1, 2, 3 });
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        result++;

                        for (int z = j; z < nums.Length - 1; z++)
                        {
                            nums[z] = nums[z + 1];
                            nums[z + 1] = -1;
                        }
                    }
                }
            }

            return result;
        }
    }
}
