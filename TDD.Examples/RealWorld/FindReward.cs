using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Examples.RealWorld
{
    public class FindReward : IFindReward
    {
        public string GuessReward(int rewardValue)
        {
            return "FreeCoins";
        }
    }
}
