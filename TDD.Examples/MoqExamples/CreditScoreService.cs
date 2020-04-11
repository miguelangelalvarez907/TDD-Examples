namespace TDD.Examples.MoqExamples
{
    public class CreditScoreService : ICreditScoreService
    {
        public string MakeCreditDecision(int creditScore)
        {
            if (creditScore < 550)
                return "Declined";
            else if (creditScore <= 675)
                return "Maybe";
            else
                return "We look forward to doing business with you!";
        }
    }
}
