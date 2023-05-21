using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    [TestClass]
    public class AtTheEndOfTermInterestDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new AtTheEndOfTermInterestDepositCalculator(null);

            var plan = sut.Calculate(100, 12, 48m, InterestPayment.AtTheEndOfTerm);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(48.02m, plan.TotalIncome);

            plan = sut.Calculate(2548, 19, 3m, InterestPayment.AtTheEndOfTerm);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(121.20m, plan.TotalIncome);
        }
    }
}
