using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.Dynamic;

namespace AlgorithmPlaygroundTests.Dynamic
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void BasicInput_Should_BeCorrect()
        {
            var input = 3;
            var expected = 2;

            var actual = Fib.Fibonacci(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargeInput_Should_StillWork()
        {
            var input = 50;
            var expected = 12586269025;

            var actual = Fib.Fibonacci(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
