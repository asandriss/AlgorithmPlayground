using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPlayground.HackerRankChallenges
{
    public class TowerBreakers
    {
        public static int PlayTowerBreakers(int numberOfTowers, int towerStartingHeight)
        {
            if(towerStartingHeight == 1 || numberOfTowers % 2 == 0)
                return 2;

            return 1;

        }
    }
}
