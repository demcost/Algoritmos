using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    public class Cases
    {
        public static int SameCase(char a, char b)
        {

            bool bothAreLetter = false;
            bool bothAreSameCase = true;

            int intA = (int)a;
            int intB = (int)b;

            if (intA >= 65 && intA <= 90 || intA >= 97 && intA <= 122)
            {
                if (intB >= 65 && intB <= 90 || intB >= 97 && intB <= 122)
                {
                    bothAreLetter = true;
                }
            }

            if (intA >= 65 && intA <= 90)
            {
                if (intB < 65 || intB > 90)
                {
                    bothAreSameCase = false;
                }
            }
            else if (intA >= 97  && intA <= 122)
            {
                if (intB < 97 || intB > 122)
                {
                    bothAreSameCase = false;
                }
            }

            if (bothAreLetter == false)
                return -1;

            if (bothAreSameCase == true)
                return 1;

            return 0;
        }
    }
}
