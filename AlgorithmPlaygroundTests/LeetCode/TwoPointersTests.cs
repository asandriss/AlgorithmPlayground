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
    public class TwoPointersTests
    {
        [TestMethod()]
        public void SubsequenceExample_ShouldBeTrue()
        {
            var inputSub = "abc";
            var inputMain = "ahbgdc";
            var expect = true;

            var actual = TwoPointers.IsSubsequence(inputSub, inputMain);

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void NonSubsequenceExample_ShouldBeFalse()
        {
            var inputSub = "axc";
            var inputMain = "ahbgdc";
            var expect = false;

            var actual = TwoPointers.IsSubsequence(inputSub, inputMain);

            actual.Should().Be(expect);
        }
    }
}