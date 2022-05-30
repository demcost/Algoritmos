using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompressionAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] input = Encoding.ASCII.GetBytes("AAAABBCDDD");

            byte[] output = Compress(input);

            Console.Read();
        }

        private static byte[] Compress(byte[] input)
        {
            byte basecharacter = input[0];
            int count = 0;
            string result = string.Empty;

            foreach(byte character in input)
            {
                if(character == basecharacter)
                {
                    count++;
                }
                else
                {
                    result += count.ToString() + (char)basecharacter;
                    basecharacter = character;
                    count = 1;
                }
            }

            return Encoding.ASCII.GetBytes(result);
        }
    }
}
