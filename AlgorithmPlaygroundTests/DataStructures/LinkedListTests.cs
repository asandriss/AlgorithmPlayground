using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.DataStructures.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        [TestMethod()]
        public void CountTest()
        {
            var obj = new LinkedList<int>(10);
            obj.Head.Next = new Node<int>(12);

            Assert.IsTrue(obj.Count() == 2);
        }

        [TestMethod()]
        public void AnyTest()
        {
            var obj = new LinkedList<int>(10);
            obj.Head.Next = new Node<int>(12);

            Assert.IsTrue(obj.Any());
        }

        [TestMethod()]
        public void AnyNoDataTest()
        {
            var obj = new LinkedList<int>();

            Assert.IsFalse(obj.Any());
        }

        [TestMethod()]
        public void AddTest()
        {
            var obj = new LinkedList<int>(10);
            obj.Add(5);

            Assert.IsTrue(obj.Head.Data == 5);
            Assert.IsTrue(obj.Head.Next.Data == 10);
        }

        [TestMethod()]
        public void Add_ToEmpty_Test()
        {
            var obj = new LinkedList<int>();
            obj.Add(5);

            Assert.IsTrue(obj.Head.Data == 5);
            Assert.IsTrue(obj.Head.Next == null);
        }

        [TestMethod()]
        public void SearchTest()
        {
            var obj = new LinkedList<int> { 5, 6, 7, 8 };

            Assert.IsTrue(obj.Search(6) != null, "Existing value not found");
            Assert.IsTrue(obj.Search(9) == null, "Search returned a result for a non-existing value");
        }

        [TestMethod()]
        public void Search_InEmptyList_Test()
        {
            var obj = new LinkedList<int>();

            Assert.IsTrue(obj.Search(9) == null, "Search returned a result for a non-existing value");
        }

        [TestMethod()]
        public void InsertTest()
        {
            var obj = new LinkedList<int>(1);
            obj.Insert(0, 0);
            obj.Insert(2, 2);

            Assert.IsTrue(obj.Head.Data == 0, "Insert at zero index failed");
            Assert.IsTrue(obj.Search(2).Data == 2, "Insert at tail index failed");

            obj.Insert(3, 2);
            Assert.AreEqual(obj.Search(3).Data, 3, "insert at arbitrary position failed");
        }

        [TestMethod()]
        public void Insert_NegativeTest_Test()
        {
            var obj = new LinkedList<int>(1);

            Assert.ThrowsException<IndexOutOfRangeException>(() => obj.Insert(0, -1));
            Assert.ThrowsException<IndexOutOfRangeException>(() => obj.Insert(0, 5));
        }

        [TestMethod()]
        public void RemoveLastElementTest()
        {
            var obj = new LinkedList<int>(10);
            obj.Add(9);
            obj.Add(8);
            obj.Add(7);

            Assert.AreEqual(4, obj.Count());
            obj.RemoveLastElement();
            Assert.AreEqual(3, obj.Count());
        }

    }
}