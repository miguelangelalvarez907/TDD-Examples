using System.Collections.Generic;
using System.Text;

namespace NUnitTests.BankAccount
{
    public interface ILog
    {
        bool WriteLog(string message);
    }
}
