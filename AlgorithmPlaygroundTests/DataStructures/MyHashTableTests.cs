using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using FluentAssertions;

namespace AlgorithmPlayground.DataStructures.Tests
{
    [TestClass()]
    public class MyHashTableTests
    {
        [TestMethod()]
        public void InitMyHashTable_Should_InitializeDataOfCorrectLength()
        {
            MyHashTable<int, string> sut = new(5);

            sut.Length.Should().Be(5);
        }

        [TestMethod()]
        public void AddValueToTheHashTable_Should_RetrieveItCorrectly()
        {
            MyHashTable<int, string> sut = new(5);

            sut.Add(1, "test");
            var actual = sut.Get(1);
            var expect = "test";

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void AddValueViaIndexer_Should_RetrieveItCorrectlyViaIndexer()
        {
            MyHashTable<int, string> sut = new(5);

            sut[1] = "test";
            var actual = sut[1];
            var expect = "test";

            actual.Should().Be(expect);
        }

        [TestMethod()]
        public void RetrievingNonExistingValue_Should_ThrowAnException()
        {
            MyHashTable<int, string> sut = new(5);

            var act = () => sut[3];
            act.Should().Throw<KeyNotFoundException>();
        }

        [TestMethod()]
        public void AddingDuplicateKeys_Should_ThrowAnException()
        {
            MyHashTable<int, string> sut = new(5);
            sut[3] = "existing value";

            var act = () => sut[3] = "new value";
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod()]
        public void AddingDistinctKeysThatHashToTheSameIndex_Should_WorkCorrectly()
        {
            MyHashTable<int, string> sut = new(5);
            sut[0] = "one";
            sut[1] = "two";
            sut[2] = "three";
            sut[3] = "four";
            sut[4] = "five";
            sut[5] = "six";
            

            var act = () => sut[3] = "new value";
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod()]
        public void StringsAsKeys_Should_WorkCorrectly()
        {
            MyHashTable<string, string> sut = new(5);
            sut["a"] = "one";
            sut["b"] = "two";
            sut["c"] = "three";
            sut["some long text"] = "four";
            sut["@##%##$@"] = "five";
            sut["escapable characters in here\t\n\r"] = "six";


            var expect = "five";
            var actual = sut["@##%##$@"];

            actual.Should().Be(expect);
        }
    }
}