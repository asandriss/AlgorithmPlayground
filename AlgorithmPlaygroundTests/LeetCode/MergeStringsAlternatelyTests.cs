using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace AlgorithmPlayground.LeetCode.Tests
{
    [TestClass]
    public class MergeStringsAlternatelyTests
    {
        [TestMethod]
        public void MergeTest()
        {
            var word1 = "ab";
            var word2 = "pqrs";
            var expect = "apbqrs";

            var actual = MergeStringsAlternately.Merge(word1, word2);

            actual.Should().Be(expect);
        }

        [TestMethod]
        public void MergeTest_FourTwo()
        {
            var word1 = "abcd";
            var word2 = "pq";
            var expect = "apbqcd";

            var actual = MergeStringsAlternately.Merge(word1, word2);

            actual.Should().Be(expect);
        }

        [TestMethod]
        public void Merge_TestSingleCharInput()
        {
            var word1 = "cdf";
            var word2 = "a";
            var expect = "cadf";

            var actual = MergeStringsAlternately.Merge(word1, word2);

            actual.Should().Be(expect);

        }
    }
}