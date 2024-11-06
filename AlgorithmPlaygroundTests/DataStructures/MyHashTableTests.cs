using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmPlayground.DataStructures;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPlaygroundTests.DataStructures
{
    [TestClass()]
    public class MyHashTableTests
    {
        [TestMethod()]
        public void Init_DefaultValue_InitializeDataOfCorrectLength()
        {
            MyHashTable<int, string> sut = new();

            sut.Length.Should().Be(0);
        }

        [TestMethod()]
        public void Init_CustomValue_InitializeDataOfCorrectLength()
        {
            MyHashTable<int, string> sut = new(5);

            sut.Length.Should().Be(0);
        }

        [TestMethod()]
        public void Add_SingleValue_SetsCorrectLength()
        {
            MyHashTable<int, string> sut = new(5);
            
            sut.Add(1, "test");
            sut.Length.Should().Be(1);
        }

        [TestMethod()]
        public void Add_MultipleValues_SetsCorrectLength()
        {
            MyHashTable<int, string> sut = new();
            var itemsToAdd = 50;

            Enumerable.Range(1, itemsToAdd).RepeatAction(x => sut.Add(x, "Item: " + x));
            
            sut.Length.Should().Be(itemsToAdd);
        }

        [TestMethod()]
        public void Add_DuplicateKey_ThrowsAnException()
        {
            MyHashTable<int, string> sut = new(5)
            {
                [3] = "existing value"
            };

            var act = () => sut[3] = "new value";
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod()]
        public void Add_ValueWithExistingIndex_ThrowsAnException()
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
        public void AddGet_SingleValue_RetrievesItCorrectly()
        {
            MyHashTable<int, string> sut = new(99);

            sut.Add(1, "test");
            var actual = sut.Get(1);
            var expect = "test";

            actual.Should().Be(expect);
        }


        [TestMethod()]
        public void Indexer_AddSingleValue_RetrieveItCorrectlyViaIndexer()
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
        public void Get_NonExistingIndex_ThrowsAnException()
        {
            MyHashTable<int, string> sut = new(66);

            var act = () => sut[3];
            act.Should().Throw<KeyNotFoundException>();
        }

        [TestMethod()]
        public void AddGet_BoundaryValues_ShouldBeAcceptedAndRetrievedCorrectly()
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
        public void AddGet_StringKeys_ShouldBeAcceptedAndRetrievedCorrectly()
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

        [TestMethod()]
        public void Remove_OnlyItem_RemoveTheItemAndShouldLeaveTheCollectionEmpty()
        {
            MyHashTable<int, string> sut = new MyHashTable<int, string>(2);

            sut.Add(5, "five");
            
            sut.Remove(5);
            var act = () => sut[5];
            
            act.Should().Throw<KeyNotFoundException>();
            sut.Length.Should().Be(0);
        }

        [TestMethod()]
        public void Remove_HashCollision_WorkCorrectly()
        {
            MyHashTable<int, string> sut = new MyHashTable<int, string>(1);

            sut.Add(5, "five");
            sut.Add(10, "ten");
            sut.Add(100, "one hundred");

            var actual = sut.Remove(10);
            var act = () => sut[10];

            actual.Should().BeTrue();
            act.Should().Throw<KeyNotFoundException>();
            sut.Length.Should().Be(2);
            sut[5].Should().BeEquivalentTo("five");
        }

        [TestMethod()]
        public void Remove_NonExistingItem_ReturnFalse()
        {
            MyHashTable<int, string> sut = new MyHashTable<int, string>(1);

            sut.Add(5, "five");
            sut.Add(10, "ten");
            sut.Add(100, "one hundred");

            var actual = sut.Remove(47);
            
            actual.Should().BeFalse();
            sut.Length.Should().Be(3);
        }
    }
}