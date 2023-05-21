using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    [TestClass]
    public class EveryYearInterestDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new EveryYearInterestDepositCalculator(null);

            var plan = sut.Calculate(100, 12, 48m, InterestPayment.EveryYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(48.02m, plan.TotalIncome);

            plan = sut.Calculate(2548, 19, 3m, InterestPayment.EveryYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(2, plan.Incomes.Count());
            Assert.AreEqual(121.20m, plan.TotalIncome);
        }
    }
}
