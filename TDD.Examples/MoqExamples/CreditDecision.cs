using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Examples.MoqExamples
{
    public class CreditDecision
    {
        private readonly ICreditScoreService _creditScoreService;

        public CreditDecision(ICreditScoreService creditScoreService)
        {
            _creditScoreService = creditScoreService;
        }

        public string MakeCreditDecision(int creditScore)
        {
            return _creditScoreService.MakeCreditDecision(creditScore);
        }
    }
}
