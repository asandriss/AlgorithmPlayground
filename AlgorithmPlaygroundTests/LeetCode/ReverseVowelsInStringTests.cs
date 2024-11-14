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
    public class ReverseVowelsInStringTests
    {
        [TestMethod()]
        public void ReverseVowelsTest()
        {
            var input = "IceCreAm";
            var expect = "AceCreIm";
            var actual = ReverseArrays.ReverseVowels(input);

            actual.Should().Be(expect);
        }
    }
}