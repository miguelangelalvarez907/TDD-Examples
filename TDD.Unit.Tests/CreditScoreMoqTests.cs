using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDD.Examples.CodeExamples;
using Moq;
using TDD.Examples.MoqExamples;

namespace TDD.Unit.Tests
{
    [TestFixture]
    class CreditScoreMoqTests
    {
        private Mock<ICreditScoreService> _mockCreditScoreService;
        private CreditDecision _creditDecision;

        [TestCase(100, "Declined", "Nah")]
        [TestCase(549, "Declined", "Nah")]
        [TestCase(550, "Maybe", "Nah")]
        [TestCase(674, "Maybe", "Nah")]
        [TestCase(675, "We look forward to doing business with you!", "Good")]
        public void Make_credit_score_check(int creditScore, string creditScoreOutput, string expectedResult)
        {
            //Arrange
            // "If your MakeCreditDecision method is invoked with this specific number (creditScore),
            //return this response (expectedResult). If it gets invoked with any other number, fail the test immediately". (that's part of MockBehavior.Strict)
            _mockCreditScoreService = new Mock<ICreditScoreService>(MockBehavior.Strict);
            _mockCreditScoreService.Setup(p => p.MakeCreditDecision(creditScore)).Returns(creditScoreOutput);

            //Act
            _creditDecision = new CreditDecision(_mockCreditScoreService.Object);
            var result = _creditDecision.MakeCreditDecision(creditScore);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            //A continuación, ejecutamos el método MakeCreditDecision tal como lo hicimos antes,
            //el único paso restante es preguntarle a nuestra instancia simulada
            //si se cumplieron todas sus expectativas usando mockCreditDecisionService.VerifyAll()
            _mockCreditScoreService.VerifyAll();
        }
    }
}
