using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.Dynamic.Tests
{
    [TestClass()]
    public class GridTravelerTests
    {
        [TestMethod()]
        public void SingleCellBaseCase_Should_ReturnOne()
        {
            var rows = 1;
            var cols = 1;

            var actual = GridTraveler.Travel(rows, cols);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ZeroCellBaseCase_Should_ReturnZero()
        {
            var expected = 0;
            var actual1 = GridTraveler.Travel(0, 0);
            var actual2 = GridTraveler.Travel(1, 0);
            var actual3 = GridTraveler.Travel(0, 1);


            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
            Assert.AreEqual(expected, actual3);
        }

        [TestMethod()]
        public void ProvidedCase_Should_Return3()
        {
            var expected = 3;

            var rows = 2;
            var cols = 3;

            var actual = GridTraveler.Travel(rows, cols);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void BigInput_Should_ReturnCorrectValue()
        {
            var expected = 985525432;

            var rows = 20;
            var cols = 20;

            var actual = GridTraveler.Travel(rows, cols);
            Assert.AreEqual(expected, actual);
        }
    }
}