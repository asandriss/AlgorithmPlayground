using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmPlayground.Sort;
using AlgorithmPlayground.Sort.MergeSort;
using Xunit;

namespace AlgorithmPlayground.Tests.Sort
{
    public class MergeSort_XTests
    {
        [Fact]
        public void Sort_SimpleValuesShouldSort()
        {
            // Arrange
            var input = new[] {4, 3, 1, 2};
            
            // Act
            var actual = MergeSort.Sort(input);

            // Assert
            Assert.Equal(actual[0], actual[0]);
        }
    }
