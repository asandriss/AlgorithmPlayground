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
    public class LinearSearchTests
    {
        [TestMethod()]
        public void SearchBasicTest()
        {
            var input = new int[] {1, 2, 3, 4};
            var obj = new LinearSearch<int>();
            var expectedResult = 2;

            Assert.IsTrue(obj.Search(input, 3) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchNotFoundTest()
        {
            var input = new int[] { 1, 2, 3, 4 };
            var obj = new LinearSearch<int>();
            var expectedResult = LinearSearch<int>.ResultNotFound;

            Assert.IsTrue(obj.Search(input, 5) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        [Ignore("Takes to long to run.")]
        public void SearchOutOfBoundTest()
        {
            var input = Enumerable.Range(1, Int32.MaxValue);
            var obj = new LinearSearch<int>();
            var expectedResult = int.MaxValue-1;

            Assert.IsTrue(obj.Search(input, int.MaxValue) == expectedResult, "Results did not match");
        }

        [TestMethod()]
        public void SearchEmptyListTest()
        {
            var obj = new LinearSearch<int>();
            
            Assert.ThrowsException<ArgumentNullException>(() => obj.Search(null, 5), "Exception was not thrown from NULL input");
        }
    }
}