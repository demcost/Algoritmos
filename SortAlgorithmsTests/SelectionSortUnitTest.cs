using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;
using System;

namespace SortAlgorithmsTests
{
    [TestClass]
    public class SelectionSortUnitTest
    {
        [TestMethod]
        public void SortTest()
        {
            int[] inputArray = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            int[] outputArray = { };

            outputArray = SelectionSort.Sort<int>(inputArray);

            int[] expectedArray = { -42, -11, -9, 0, 1, 6, 12, 68, 90 };

            CollectionAssert.AreEqual(expectedArray, outputArray);
        }
    }
}
