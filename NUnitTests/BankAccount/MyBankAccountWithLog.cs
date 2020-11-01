using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests.BankAccount
{
    public class MyBankAccountWithLog
    {
        private readonly ILog _log;
        public int Balance { get; private set; }

        public MyBankAccountWithLog(ILog log, int startingBalance)
        {
            _log = log;
            Balance = startingBalance;
        }

        public void Deposit(int amount)
        {
            _log.WriteLog($"User has deposited: {amount}");

            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive", nameof(amount));
            }

            Balance += amount;
        }

        public bool WithDraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }

            return false;
        }
    }
}
