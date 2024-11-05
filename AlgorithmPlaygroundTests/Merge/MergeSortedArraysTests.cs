using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.Merge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace AlgorithmPlayground.Merge.Tests
{
    [TestClass()]
    public class MergeSortedArraysTests
    {
        [TestMethod()]
        public void SendAnEmptyArray_Should_ReturnTheNonEmptyOneOrSecond()
        {
            var arr1 = new int[] { 1 };
            var arr2 = new int[] { };

            var actual = MergeSortedArrays.Merge(arr1, arr2);

            actual.Should().Equal(arr1);

            var actual2 = MergeSortedArrays.Merge(arr2, arr1);
            actual2.Should().Equal(arr1);

            var actual3 = MergeSortedArrays.Merge(arr1, null);
            actual3.Should().Equal(arr1);
        }

        [TestMethod()]
        [Ignore("not implemented yet - upgrade .net version first")]
        public void TwoSingleElementArrays_Should_TwoRecordsInCorrectOrder()
        {
            var arr1 = new int[] { 2 };
            var arr2 = new int[] { 1 };

            var actual = MergeSortedArrays.Merge(arr1, arr2);
            var expect = new int[] { 1, 2 }
            ;

            actual.Should().Equal(expect);
        }
    }
}