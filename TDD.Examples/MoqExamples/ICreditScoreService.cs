using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Examples.MoqExamples
{
    public interface ICreditScoreService
    {
        string MakeCreditDecision(int creditScore);
    }
}
