using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostIncreaseSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 1, 2 };

            solution1(sequence);
        }

        static bool solution1(int[] sequence)
        {
            bool returnValue = true;

            int count = 0;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                {
                    count++;
                }

                if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
                {
                    count++;
                }
                
            }

            if(count >= 2)
                returnValue = false;

            return returnValue;
        }


        static bool solution(int[] sequence)
        {
            int x = 0;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] >= sequence[i + 1])
                    x++;
                if (i + 2 < sequence.Length && sequence[i] >= sequence[i + 2])
                    x++;
            }
            return x <= 2;
        }
    }
}
