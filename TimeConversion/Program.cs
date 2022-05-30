using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    public class Program
    {
        public static string timeConversion(string s)
        {
            string timeConverted = string.Empty;

            string[] time = s.Split(':');
            int hour = 0;
            int minute = 0;
            int second = 0;

            //hour
            hour = Int32.Parse(time[0]);
            minute = Int32.Parse(time[1]);
            second = Int32.Parse(time[2].Substring(0, 2));

            if (s.Contains("PM"))
            {
                if (hour < 12)
                    hour = hour + 12;
            }
            else if (s.Contains("AM"))
            {
                if (hour == 12)
                    hour = 0;
            }

            timeConverted = String.Format("{0:00}:{1:00}:{2:00}", hour, minute, second);

            return timeConverted;
        }


        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Program.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
