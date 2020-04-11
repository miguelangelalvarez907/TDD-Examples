using System;
using Lotto.Age.Predictor.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Lotto.Age.Units
{
    [TestFixture]
    public class UserUnitTests
    {
        private IUser _user;

        [SetUp]
        public void SetUp()
        {
            _user = new User();
        }

        [TestCase("Jefff")]
        [TestCase("Bobb")]
        [TestCase("Kiran")]
        [TestCase("123456789")]
        public void Is_user_name_less_than_9_in_length(string name)
        {
            var result = _user.ValidateName(name);

            NUnit.Framework.Assert.That(result, Is.True);
        }
    }
}
