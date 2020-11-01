using Moq;
using NUnit.Framework;
using NUnitTests.BankAccount;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests
{
    [TestFixture]
    public class MoqBankAccountTests
    {
        private MyBankAccountWithLog _myBankAccountWithLog;
        private Mock<ILog> _log;

        [SetUp]
        public void Setup()
        {
            _log = new Mock<ILog>();
        }

        [Test]
        public void Deposit_Test()
        {
            _myBankAccountWithLog = new MyBankAccountWithLog(_log.Object, 100);

            _myBankAccountWithLog.Deposit(100);

            Assert.That(_myBankAccountWithLog.Balance, Is.EqualTo(200));
        }
    }
}
