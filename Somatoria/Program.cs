using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            int min = -100;

            string sResult = Console.ReadLine();
            int sumResult = 0;

            if (Int32.TryParse(sResult, out sumResult))
            {
                max = max + sumResult;

                int[] result = new int[sumResult];

                for (int i = 1; i < sumResult; i++)
                {
                    Random random = new Random();
                    int sumValue = random.Next(min, max);

                    if (min <= sumValue && sumValue <= max)
                    {
                        result[i - 1] = sumValue;

                        if (sumValue >= 0)
                        {
                            max = max - sumValue;
                        }
                        else
                        {
                            min = min - sumValue;
                        }
                    }
                    else
                    {
                        i--;
                    }
                }

                result[result.Length - 1] = min + max;
            }

            
        }
    }
}
