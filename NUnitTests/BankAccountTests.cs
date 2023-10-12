using NUnit.Framework;
using NUnitTests.BankAccount;
using System;

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
        public void BankAccount_debe_arrojar_una_excepcion_por_numero_negativo()
        {
            var ex = Assert.Throws<ArgumentException>(() =>
            {
                _myBankAccount.Deposit(-1);
            });

            StringAssert.StartsWith("Deposit amount must be positive", ex.Message);
        }

        [Test]
        public void BankAccount_debe_incrementar_en_100()
        {
            _myBankAccount.Deposit(100);

            Assert.That(_myBankAccount.Balance, Is.EqualTo(200));
        }

        
    }
}
