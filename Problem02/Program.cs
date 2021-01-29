using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        public static int countingValleys(int steps, string path)
        {
            int returnValue = 0;
            int currentSeaLevel = 0;
            bool insideValley = false;
            char[] stepsItems = path.ToArray();

            for(int i = 0; i <= steps - 1; i++)
            {
                // at this step, if hiker is in the sea level and next steps is downhill, it will go inside a Valley
                if(currentSeaLevel == 0 && stepsItems[i] == 'D')
                {
                    insideValley = true;
                }

                if(insideValley == true && 
                    stepsItems[i] == 'U' && 
                    (currentSeaLevel + 1) == 0 )
                {
                    returnValue++;
                    insideValley = false;
                }

                if (stepsItems[i] == 'U')
                   currentSeaLevel++;

                if (stepsItems[i] == 'D')
                    currentSeaLevel--;
            }

            return returnValue;
        }

        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
