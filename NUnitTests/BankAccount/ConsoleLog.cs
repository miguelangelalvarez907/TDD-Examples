using System;

namespace NUnitTests.BankAccount
{
    public class ConsoleLog : ILog
    {
        public bool WriteLog(string message)
        {
            Console.WriteLine(message);

            return true;
        }
    }
}
