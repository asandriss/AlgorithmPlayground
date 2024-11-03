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
    public class NodeTests
    {
        [TestMethod()]
        public void NodeTest()
        {
            var obj = new Node<int>(10);
            obj.Next = new Node<int>(15);

            Assert.IsTrue(obj.Next.Data == 15);
        }
    }
}