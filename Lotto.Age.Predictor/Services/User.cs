using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Age.Predictor.Services
{
    public class User : IUser
    {
        private const int ValidationLength = 9;
        public bool ValidateName(string name)
        {
            var count = name.Length;

            if (count > ValidationLength)
                return false;

            return true;
        }
    }
}
