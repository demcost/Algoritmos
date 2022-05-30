using NUnit.Framework;
using System;

namespace SameCase
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

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

            if (65 >= intA && intA <= 90)
            {
                if (intB < 65 || intB > 90)
                {
                    bothAreSameCase = false;
                }
            }
            else if (97 >= intA && intA <= 122)
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


        [Test]
        public void TrueTests()
        {
            Assert.AreEqual(1, Program.SameCase('a', 'u'));
            Assert.AreEqual(1, Program.SameCase('A', 'U'));
            Assert.AreEqual(1, Program.SameCase('Q', 'P'));
            Assert.AreEqual(1, Program.SameCase('w', 'y'));
            Assert.AreEqual(1, Program.SameCase('c', 'm'));
            Assert.AreEqual(1, Program.SameCase('N', 'W'));
        }
        [Test]
        public void FalseTests()
        {
            Assert.AreEqual(0, Program.SameCase('a', 'U'));
            Assert.AreEqual(0, Program.SameCase('A', 'u'));
            Assert.AreEqual(0, Program.SameCase('Q', 'p'));
            Assert.AreEqual(0, Program.SameCase('w', 'Y'));
            Assert.AreEqual(0, Program.SameCase('c', 'M'));
            Assert.AreEqual(0, Program.SameCase('N', 'w'));
        }
        [Test]
        public void NotLetters()
        {
            Assert.AreEqual(-1, Program.SameCase('a', '*'));
            Assert.AreEqual(-1, Program.SameCase('A', '%'));
            Assert.AreEqual(-1, Program.SameCase('Q', '1'));
            Assert.AreEqual(-1, Program.SameCase('w', '-'));
            Assert.AreEqual(-1, Program.SameCase('c', '8'));
            Assert.AreEqual(-1, Program.SameCase('N', ':'));
        }
    }
}
