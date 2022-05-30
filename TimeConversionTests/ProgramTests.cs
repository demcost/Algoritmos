using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MidNightConversionTest()
        {
            Assert.AreEqual("00:01:01", Program.timeConversion("12:01:01AM"));
        }

        [TestMethod()]
        public void NoonConversionTest()
        {
            Assert.AreEqual("12:01:01", Program.timeConversion("12:01:01PM"));
        }

        [TestMethod()]
        public void afterNoonConversionTest()
        {
            Assert.AreEqual("13:59:28", Program.timeConversion("1:59:28PM"));
        }

        [TestMethod()]
        public void beforeNoonConversionTest()
        {
            Assert.AreEqual("01:59:28", Program.timeConversion("1:59:28AM"));
        }
    }
}