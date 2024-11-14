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
    public class ReverseArraysTests
    {
        [TestMethod()]
        public void ReverseWords_ReverseTheOrderOfWordsInAString()
        {
            var input = "the sky is blue";
            var expect = "blue is sky the";

            var actual = ReverseArrays.ReverseWords(input);

            actual.Should().Be(expect);

        }
    }
}