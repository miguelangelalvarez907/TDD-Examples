using System;
using Lotto.Age.Predictor.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Lotto.Age.Units
{
    [TestFixture]
    public class LottoPredictorUnitTests
    {
        private ILottoAge _lottoAge;

        [SetUp]
        public void SetUp()
        {
            _lottoAge = new LottoAge();
        }

        [TestCase(2020)]
        [TestCase(2021)]
        [TestCase(1999)]
        [TestCase(1989)]
        public void Is_year_valid_on_selection_of_date_of_birth(int year)
        {
            var result = _lottoAge.CalculateAge(year);

            NUnit.Framework.Assert.That(result, Is.GreaterThan(0));
        }
    }
}
