using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Tests
{
    [TestClass()]
    public class CasesTests
    {
        [TestMethod]
        public void TrueTests()
        {
            Assert.AreEqual(1, Cases.SameCase('a', 'u'));
            Assert.AreEqual(1, Cases.SameCase('A', 'U'));
            Assert.AreEqual(1, Cases.SameCase('Q', 'P'));
            Assert.AreEqual(1, Cases.SameCase('w', 'y'));
            Assert.AreEqual(1, Cases.SameCase('c', 'm'));
            Assert.AreEqual(1, Cases.SameCase('N', 'W'));
        }

        [TestMethod]
        public void FalseTests()
        {
            Assert.AreEqual(0, Cases.SameCase('a', 'U'));
            Assert.AreEqual(0, Cases.SameCase('A', 'u'));
            Assert.AreEqual(0, Cases.SameCase('Q', 'p'));
            Assert.AreEqual(0, Cases.SameCase('w', 'Y'));
            Assert.AreEqual(0, Cases.SameCase('c', 'M'));
            Assert.AreEqual(0, Cases.SameCase('N', 'w'));
        }

        [TestMethod]
        public void NotLetters()
        {
            Assert.AreEqual(-1, Cases.SameCase('a', '*'));
            Assert.AreEqual(-1, Cases.SameCase('A', '%'));
            Assert.AreEqual(-1, Cases.SameCase('Q', '1'));
            Assert.AreEqual(-1, Cases.SameCase('w', '-'));
            Assert.AreEqual(-1, Cases.SameCase('c', '8'));
            Assert.AreEqual(-1, Cases.SameCase('N', ':'));
        }
    }
}