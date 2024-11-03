using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlgorithmPlayground.Facebook;

namespace AlgorithmPlaygroundTests.Facebook
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void SampleCorrect_Should_BeTrue()
        //{
        //    var words = new[] { "hello", "leetcode" };
        //    var order = "hlabcdefgijkmnopqrstuvwxyz";

        //    var dictionary = new AlienDictionary(order);
            
        //    var result = dictionary.Verify(words);

        //    Assert.IsTrue(result);
        //}

        [TestMethod]
        public void SampleIncorrect_Should_BeFalse()
        {
            var words = new[] { "word", "world", "row" };
            var order = "worldabcefghijkmnpqstuvxyz";

            var dictionary = new AlienDictionary(order);

            var result = dictionary.Verify(words);

            Assert.IsFalse(result);
        }
    }

    
}
