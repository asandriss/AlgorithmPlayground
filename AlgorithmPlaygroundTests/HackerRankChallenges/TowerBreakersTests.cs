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
    public class TowerBreakersTests
    {
        [TestMethod()]
        public void SimplestInput_PlayerTwoWins()
        {
            int actual = TowerBreakers.PlayTowerBreakers(1, 4);
            int expect = 1;

            Assert.AreEqual(expect, actual);
        }

        [TestMethod()]
        public void ChallengeInput_PlayerTwoWins()
        {
            int actual = TowerBreakers.PlayTowerBreakers(2, 6);
            int expect = 2;

            Assert.AreEqual(expect, actual);
        }
    }
}