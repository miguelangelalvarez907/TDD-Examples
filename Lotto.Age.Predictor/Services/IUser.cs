using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Age.Predictor.Services
{
    public interface IUser
    {
        bool ValidateName(string name);
    }
}
