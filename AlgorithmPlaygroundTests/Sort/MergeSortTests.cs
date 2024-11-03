using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Sort.Tests
{
    [TestClass()]
    public class MergeSortTests
    {
        [TestMethod()]
        public void Sort_Basic_Test()
        {
            var input = new[] {4, 3, 1, 2};
            var actual = MergeSort.Sort(input);
            var expected = new[] {1, 2, 3, 4};


            Assert.AreEqual(input.Length, actual.Length);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sort_EmptySource_Test()
        {
            var input = new int[] {};
            var actual = MergeSort.Sort(input);
            var expected = new int[] {  };

            Assert.AreEqual(input.Length, actual.Length);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Sort_LargerDataSet_Test()
        {
            var rnd = new Random((int) DateTime.UtcNow.Ticks);

            var input = Enumerable.Range(-2500, 5000).Select(e => e * rnd.Next(1, 5)).ToArray();
            
            var actual = MergeSort.Sort(input);
            var expected = input.OrderBy(i => i).ToArray();

            Assert.AreEqual(input.Length, actual.Length);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}