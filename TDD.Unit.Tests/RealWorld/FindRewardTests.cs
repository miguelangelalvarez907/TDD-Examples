using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDD.Examples.RealWorld;

namespace TDD.Unit.Tests.RealWorld
{
    [TestFixture]
    class FindRewardTests
    {
        private IFindReward _findReward;  
        [SetUp]
        public void Setup()
        {
            _findReward = new FindReward();
        }

        [TestCase(1, "FreeCoins")]
        public void Check_for_reward_matches_value(int rewardValue, string expectedResult)
        {
            var result = _findReward.GuessReward(rewardValue);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
