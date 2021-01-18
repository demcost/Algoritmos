using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] inputArray = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };

            int[] outputArray = BubbleSort.Sort(inputArray);

            int[] expectedArray = { -42, -11, -9, 0, 1, 6, 12, 68, 90 };

            CollectionAssert.AreEqual(expectedArray, outputArray);
        }
    }
}