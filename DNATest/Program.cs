using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DNATest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetDuplicates("AATCGGTTA");
            BenchmarkRunner.Run<AnotherProgram>();

        }

        public static void GetDuplicates(string DNASequence)
        {
            HashSet<char> validChars = new HashSet<char>() { 'A', 'C', 'T', 'G' };

            HashSet<string> duplicates = new HashSet<string>();

            for (int i = 1; i < DNASequence.Length; i++)
            {

                if (!validChars.Contains(DNASequence[i]))
                {
                    continue;
                }

                if (DNASequence[i - 1] == DNASequence[i])
                {
                    string singleSequence = string.Concat(DNASequence[i], DNASequence[i]);

                    if (!duplicates.Contains(singleSequence))
                    {
                        duplicates.Add(singleSequence);
                    }
                }
            }


        }



    }

    [MemoryDiagnoser]
    public class AnotherProgram
    {
        HashSet<char> validChars = new HashSet<char>() { 'A', 'C', 'T', 'G' };
        char[] validCharsSlow = new char[] { 'A', 'C', 'T', 'G' };

        public AnotherProgram()
        {

        }

        [Benchmark]
        [Arguments("AATCGGTTA")]
        public void GetDuplicates(string DNASequence)
        {
            HashSet<string> duplicates = new HashSet<string>();

            for (int i = 1; i < DNASequence.Length; i++)
            {

                if (!validChars.Contains(DNASequence[i]))
                {
                    continue;
                }

                if (DNASequence[i - 1] == DNASequence[i])
                {
                    char character = DNASequence[i];

                    string singleSequence = string.Concat(character, character);

                    if (!duplicates.Contains(singleSequence))
                    {
                        duplicates.Add(singleSequence);
                    }
                }
            }
        }


        [Benchmark(Baseline = true)]
        [Arguments("AATCGGTTA")]
        public void GetDuplicatesSlow(string DNASequence)
        {
            List<string> duplicates = new List<string>();

            for (int i = 1; i < DNASequence.Length; i++)
            {

                if (!validCharsSlow.Contains(DNASequence[i]))
                {
                    continue;
                }

                if (DNASequence[i - 1] == DNASequence[i])
                {
                    string singleSequence = DNASequence[i - 1].ToString() + DNASequence[i].ToString();

                    if (!duplicates.Contains(singleSequence))
                    {
                        duplicates.Add(singleSequence);
                    }
                }
            }
        }
    }
}
