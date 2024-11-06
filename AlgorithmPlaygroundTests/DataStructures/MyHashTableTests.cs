using System;
using System.Collections.Generic;
using AlgorithmPlayground.DataStructures;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPlaygroundTests.DataStructures
{
    [TestClass()]
    public class MyHashTableTests
    {
        [TestMethod()]
        public void InitMyHashTable_Should_InitializeDataOfCorrectLength()
        {
            MyHashTable<int, string> sut = new(5);

            sut.Length.Should().Be(0);
        }

        [TestMethod()]
        public void AddingItemsToTheHashTableShouldSetLengthCorrectly_Should_InitializeDataOfCorrectLength()
        {
            MyHashTable<int, string> sut = new(5);
            
            sut.Add(1, "test");
            sut.Length.Should().Be(1);
        }

        [TestMethod()]
        public void AddValueToTheHashTable_Should_RetrieveItCorrectly()
        {
            MyHashTable<int, string> sut = new(99);

            sut.Add(1, "test");
            var actual = sut.Get(1);
            var expect = "test";

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void AddValueViaIndexer_Should_RetrieveItCorrectlyViaIndexer()
        {
            MyHashTable<int, string> sut = new(1)
            {
                [1] = "test"
            };

            var actual = sut[1];
            var expect = "test";

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void RetrievingNonExistingValue_Should_ThrowAnException()
        {
            MyHashTable<int, string> sut = new(66);

            var act = () => sut[3];
            act.Should().Throw<KeyNotFoundException>();
        }

        [TestMethod()]
        public void AddingDuplicateKeys_Should_ThrowAnException()
        {
            MyHashTable<int, string> sut = new(5)
            {
                [3] = "existing value"
            };

            var act = () => sut[3] = "new value";
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod()]
        public void AddingDistinctKeysThatHashToTheSameIndex_Should_WorkCorrectly()
        {
            MyHashTable<int, string> sut = new(5)
            {
                [0] = "one",
                [1] = "two",
                [2] = "three",
                [3] = "four",
                [4] = "five",
                [5] = "six"
            };


            var act = () => sut[3] = "new value";
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod()]
        public void NegativeAndLargeNumbersForIndexes_Should_WorkCorrectly()
        {
            MyHashTable<int, string> sut = new(5)
            {
                [-1] = "minus one",
                [Int32.MaxValue] = "big",
                [Int32.MinValue] = "small",
            };

            sut[-1].Should().BeEquivalentTo("minus one");
            sut[Int32.MaxValue].Should().BeEquivalentTo("big");
            sut[Int32.MinValue].Should().BeEquivalentTo("small");
        }

        [TestMethod()]
        public void StringsAsKeys_Should_WorkCorrectly()
        {
            MyHashTable<string, string> sut = new(5)
            {
                ["a"] = "one",
                ["b"] = "two",
                ["c"] = "three",
                ["some long text"] = "four",
                ["@##%##$@"] = "five",
                ["escapable characters in here\t\n\r"] = "six"
            };


            var expect = "five";
            var actual = sut["@##%##$@"];

            actual.Should().Be(expect);
        }
    }
}