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
    public class MoveZeroesTests
    {
        [TestMethod()]
        public void TestEmptyArray_ShouldNotAffectTheInput()
        {
            var input1actual = new int[] { };
            int[] input2actual = null;
            var input3actual = new int[] { 55 };

            var expect1 = Array.Empty<int>();
            int[] expect2 = null;
            int[] expect3 = new int[] { 55 };

            MoveZeroes.MoveZeroesToTheEnd(input1actual);
            MoveZeroes.MoveZeroesToTheEnd(input2actual);

            input1actual.Should().Equal(expect1);
            input2actual.Should().Equal(expect2);
            input3actual.Should().Equal(expect3);
        }

        [TestMethod()]
        public void TwoElementsWithLeadingZero_Should_MoveZeroBack()
        {
            var input1actual = new int[] { 0, 1 };
            var expect = new int[] { 1, 0 };

            MoveZeroes.MoveZeroesToTheEnd(input1actual);

            input1actual.Should().Equal(expect);
        }

        [TestMethod()]
        public void ManyNonconsecutiveZeros_Should_MoveZeroBack()
        {
            var input1actual = new int[] { 0, 1, 2, 0, 3, 0, 4 };
            var expect = new int[] { 1, 2, 3, 4, 0, 0, 0 };

            MoveZeroes.MoveZeroesToTheEnd(input1actual);

            input1actual.Should().Equal(expect);
        }
    }
}