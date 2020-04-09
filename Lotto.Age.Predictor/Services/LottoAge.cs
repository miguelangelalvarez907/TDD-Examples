using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Age.Predictor.Services
{
    public class LottoAge : ILottoAge
    {
        private const int MaxAge = 150;
        private Random Random;

        public LottoAge()
        {
            Random = new Random();
        }

        public int CalculateAge(int year)
        {
            var dob = DateTime.Now.Year - year;

            if (dob >= double.Epsilon)
                return dob;
            else throw new ArgumentOutOfRangeException();
        }

        public int PredictLottoAge(int age)
        {
            var predictWinningAge = Random.Next(age, MaxAge);

            return predictWinningAge >= double.Epsilon ? predictWinningAge : -1;
        }
    }
}
