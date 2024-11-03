using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Search.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        [TestMethod()]
        public void SearchBasicTest()
        {
            var input = new int[] { 1, 2, 3, 4, 5 };
            var searchTerm = 3;
            var obj = new BinarySearch<int>();
            var expectedResult = 2;

            Assert.IsTrue(obj.Search(input, searchTerm) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchEmptyInputTest()
        {
            var input = new int[] { };
            var searchTerm = 3;
            var obj = new BinarySearch<int>();
            var expectedResult = BinarySearch<int>.NotFound;

            Assert.IsTrue(obj.Search(input, searchTerm) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchInFirstHalfTest()
        {
            var input = Enumerable.Range(1, 6).ToList();
            var searchTerm = 5;
            var obj = new BinarySearch<int>();
            var expectedResult = searchTerm-1;

            Assert.IsTrue(obj.Search(input, searchTerm) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchLowerLimitTest()
        {
            var input = Enumerable.Range(1, 6).ToList();
            var searchTerm = 1;
            var obj = new BinarySearch<int>();
            var expectedResult = searchTerm - 1;

            Assert.IsTrue(obj.Search(input, searchTerm) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchUpperLimitTest()
        {
            var input = Enumerable.Range(1, 6).ToList();
            var searchTerm = 6;
            var obj = new BinarySearch<int>();
            var expectedResult = searchTerm - 1;

            Assert.IsTrue(obj.Search(input, searchTerm) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchInSecondHalfTest()
        {
            var input = Enumerable.Range(1, 100).ToList();
            var searchTerm = 74;
            var obj = new BinarySearch<int>();
            var expectedResult = searchTerm - 1;

            Assert.IsTrue(obj.Search(input, searchTerm) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchNonExistingTest()
        {
            var obj = new BinarySearch<int>();

            var input = new int[] { 1, 2, 3, 4 };
            var searchTerm = 5;
            var expectedResult = BinarySearch<int>.NotFound;

            Assert.IsTrue(obj.Search(input, searchTerm) == expectedResult, "Index was found for a non-existing term");
        }

        [TestMethod()]
        public void SearchInt16MaxTest()
        {
            var obj = new BinarySearch<int>();

            var input = Enumerable.Range(1, 1000000);
            var searchTerm = 99999;
            var expectedResult = searchTerm - 1;

            Assert.IsTrue(obj.Search(input.ToList(), searchTerm) == expectedResult, "Results did not match");
        }
    }


}