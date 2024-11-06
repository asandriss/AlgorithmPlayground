using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace AlgorithmPlayground.DataStructures.Tests
{
    [TestClass()]
    public class MyHashTableTests
    {
        [TestMethod()]
        public void InitMyHashTable_Should_InitializeDataOfCorrectLength()
        {
            MyHashTable sut = new(5);

            sut.Length.Should().Be(5);
        }

        [TestMethod()]
        public void AddValueToTheHashTable_Should_RetrieveItCorrectly()
        {
            MyHashTable sut = new(5);

            sut.Add(1, "test");
            var actual = sut.Get(1);
            var expect = "test";

            actual.Should().Be(expect);
        }
    }
}