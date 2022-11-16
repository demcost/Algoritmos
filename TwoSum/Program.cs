using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace TwoSum
{
    [MemoryDiagnoser]
    public class SumProgram
    {

        public IEnumerable<object[]> Data()
        {
            yield return new object[] { new int[] { 0, 2, 1, 7, 15, 31, 16, 18, 20, 40, 25, 38, 26, 27, 29, 30, 11, 51, 35, 37, 45, 49, 50, 52, 53, 55, 57, 60, 61, 62, 63, 64, 65, 66, 67, 70, 73, 74, 75, 80, 81, 83, 84, 85, 87, 88, 90 }, 26 };

        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Data))]
        public int[] TwoSum_On2(int[] nums, int target)
        {
            int[] returnArray = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        returnArray.SetValue(i, 0);
                        returnArray.SetValue(j, 1);

                        return returnArray;
                    }
                }
            }



            return returnArray;
        }


        [Benchmark]
        [ArgumentsSource(nameof(Data))]

        public int[] TwoSum_On(int[] nums, int target)
        {
            Dictionary<int, int> numsDictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                int index = target - num;

                if (numsDictionary.ContainsKey(index))
                {
                    return new[] { index, i };
                }

                numsDictionary[num] = i;
            }

            return new int[] { -1, -1 };

        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SumProgram>();

            //SumProgram sumprogram = new SumProgram();
            //sumprogram.TwoSumOther(new int[] { 0, 1, 2, 7 }, 9);

            Console.ReadLine();   
        }

        
    }
}