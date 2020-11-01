using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests.BankAccount
{
    public class MyBankAccount
    {
        public int Balance { get; private set; }

        public MyBankAccount(int startingBalance)
        {
            Balance = startingBalance;
        }

        public void Deposit(int amount)
        {
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
