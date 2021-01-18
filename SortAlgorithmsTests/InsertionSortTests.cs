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
    public class InsertionSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] inputArray = { -15, 0, 21, 4, 9, 8, 15, 2 };

            int[] expectedArray = { -15, 0, 2, 4, 8, 9, 15, 21 };

            int [] outputArray = InsertionSort.Sort(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);
        }


        [TestMethod()]
        public void SortFromBookTest()
        {
            int[] inputArray = { -15, 0, 21, 4, 9, 8, 15, 2 };

            int[] expectedArray = { -15, 0, 2, 4, 8, 9, 15, 21 };

            int[] outputArray = InsertionSort.SortFromBook(inputArray);

            CollectionAssert.AreEqual(expectedArray, outputArray);
        }
    }
}