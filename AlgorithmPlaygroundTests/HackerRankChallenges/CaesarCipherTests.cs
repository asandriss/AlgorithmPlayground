using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPlayground.HackerRankChallenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.HackerRankChallenges.Tests
{
    [TestClass()]
    public class CaesarCipherTests
    {
        [TestMethod()]
        public void SingleCharacter_MoveBy1_CorrectResponse()
        {
            string input = "a";
            var expect = "b";
            var actual = CaesarCipher.Encrypt(input, 1);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void SingleCharacterAtTheEndOfSequence_MoveBy1_CorrectlyLoopsThrough()
        {
            string input = "z";
            var expect = "a";
            var actual = CaesarCipher.Encrypt(input, 1);

            Assert.AreEqual(expect, actual);
        }

        //[TestMethod()]
        //public void CaptialLetters_MoveBy1_CorrectlyLoopsThrough()
        //{
        //    string input = "z";
        //    var expect = "a";
        //    var actual = CaesarCipher.Encrypt(input, 1);

        //    Assert.AreEqual(expect, actual);
        //}

        [TestMethod()]
        public void ProvidedInput_Returns_ProvidedOutput()
        {
            string input = "middle-Outz";
            var expect = "okffng-Qwvb";
            var actual = CaesarCipher.Encrypt(input, 2);

            Assert.AreEqual(expect, actual);
        }
    }
}