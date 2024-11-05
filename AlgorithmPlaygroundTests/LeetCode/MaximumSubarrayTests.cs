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
    [TestClass()]
    public class MaximumSubarrayTests
    {
        [TestMethod()]
        public void EmptyArray_ShouldReturn_Zero()
        {
            var expect = 0;
            var input = new int[0];

            var actual = MaximumSubarray.GetMax(input);

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void SingleElementInput_ShouldReturn_ElementAtZero()
        {
            var expect = 55;
            var input = new int[] { 55 };

            var actual = MaximumSubarray.GetMax(input);

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void TwoPositiveValues_ShouldReturn_Sums()
        {
            var expect = 69;
            var input = new int[] { 55, 14 };

            var actual = MaximumSubarray.GetMax(input);

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void ProvidedInput_ShouldReturn_MaxSubarray()
        {
            var expect = 6;
            var input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            var actual = MaximumSubarray.GetMax(input);

            actual.Should().Be(expect);
        }

    }
}