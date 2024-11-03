using AlgorithmPlayground.Search;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPlaygroundTests.Search
{
    [TestClass()]
    public class CompareTwoArraysTests
    {
        [TestMethod()]
        public void Basic_False_Case()
        {
            var first = new[] { 1, 2, 3, 4 };
            var second = new[] { 5, 6, 7 };

            var expect = false;
            var actual = CompareTwoArrays.CompareTwoArraysFun(first, second);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void Basic_True_Case()
        {
            var first = new[] { 1, 2, 3, 4 };
            var second = new[] { 5, 6, 7, 1 };

            var expect = true;
            var actual = CompareTwoArrays.CompareTwoArraysFun(first, second);

            Assert.AreEqual(expect, actual);
        }
    }
}

