using NUnit.Framework;
using NUnitTests.BankAccount;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class DataDrivenTests
    {
        private MyBankAccount _mybankAccount;

        [SetUp]
        public void Setup()
        {
            _mybankAccount = new MyBankAccount(100);
        }

        [Test]
        [TestCase(50, true, 50)]
        [TestCase(100, true, 0)]
        [TestCase(1000, false, 100)]
        [TestCase(101, false, 100)]
        [TestCase(99, true, 1)]
        [TestCase(90, true, 10)]
        public void Test_Multiple_Withdraws(int amountToWithdraw, bool shouldSucceed, int expectedBalance)
        {
            var result = _mybankAccount.WithDraw(amountToWithdraw);

            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo(shouldSucceed));
                Assert.That(expectedBalance, Is.EqualTo(_mybankAccount.Balance));
            });
        }
    }
}
