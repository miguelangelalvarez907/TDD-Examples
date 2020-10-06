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
            var decision = _creditScoreService.MakeCreditDecision(creditScore).ToLower();

            if (decision == "declined" || decision == "maybe")
            {
                return "Nah";
            }

            return "Good";
        }
    }
}
