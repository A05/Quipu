using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Sx.Vx.Quipu.Domain
{
    [TestClass]
    public class AtTheEndOfTermInterestDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new AtTheEndOfTermInterestDepositCalculator(null);

            var plan = sut.Calculate(100m, 12, 25m, InterestPayment.AtTheEndOfTerm);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(25m, plan.TotalIncome);
        }
    }
}
