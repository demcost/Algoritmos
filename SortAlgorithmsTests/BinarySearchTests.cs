using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchSucceededTest()
        {
            int[] searchArray = { 6,7,8,9,10,11,14,15,17,19,22,23,25,28,30 };

            bool outputValue = BinarySearch.Search(searchArray, 19);

            Assert.AreEqual(true, outputValue);
        }

        [TestMethod()]
        public void SearchFailedTest()
        {
            int[] searchArray = { 6, 7, 8, 9, 10, 11, 14, 15, 17, 19, 22, 23, 25, 28, 30 };

            bool outputValue = BinarySearch.Search(searchArray, 12);

            Assert.AreEqual(false, outputValue);
        }
    }
}