using NUnit.Framework;
using NUnitTests.BankAccount;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private MyBankAccount _myBankAccount;

        [SetUp]
        public void Setup()
        {
            _myBankAccount = new MyBankAccount(100);
        }

        [Test]
        public void BankAccount_Should_Increase_On_Postive_Deposit()
        {
            _myBankAccount.Deposit(100);

            Assert.That(_myBankAccount.Balance, Is.EqualTo(200));
        }

        [Test]
        public void BankAccount_Should_Throw_An_Exception_On_Negative_Number()
         {
            var ex = Assert.Throws<ArgumentException>(() =>
            {
                _myBankAccount.Deposit(-1);
            });

            StringAssert.StartsWith("Deposit amount must be positive", ex.Message);
        }
    }
}
