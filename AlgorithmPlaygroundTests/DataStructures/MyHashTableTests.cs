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

        [TestMethod()]
        public void AddValueViaIndexer_Should_RetrieveItCorrectlyViaIndexer()
        {
            MyHashTable sut = new(5);

            sut[1] = "test";
            var actual = sut[1];
            var expect = "test";

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void RetrievingNonExistingValue_Should_ThrowAnException()
        {
            MyHashTable sut = new(5);

            var act = () => sut[3];
            act.Should().Throw<KeyNotFoundException>();
        }

        [TestMethod()]
        public void AddingDuplicateKeys_Should_ThrowAnException()
        {
            MyHashTable sut = new(5);
            sut[3] = "existing value";

            var act = () => sut[3] = "new value";
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod()]
        public void AddingDistinctKeysThatHashToTheSameIndex_Should_WorkCorrectly()
        {
            MyHashTable sut = new(5);
            sut[0] = "one";
            sut[1] = "two";
            sut[2] = "three";
            sut[3] = "four";
            sut[4] = "five";
            sut[5] = "six";
            

            var act = () => sut[3] = "new value";
            act.Should().Throw<ArgumentException>();
        }
    }
}