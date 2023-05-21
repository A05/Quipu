using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    [TestClass]
    public class EveryQuarterInterestDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new EveryQuarterInterestDepositCalculator(null);

            var plan = sut.Calculate(100, 12, 48m, InterestPayment.EveryQuarter);

            Assert.IsNotNull(plan);
            Assert.AreEqual(4, plan.Incomes.Count());
            Assert.AreEqual(48.02m, plan.TotalIncome);

            plan = sut.Calculate(2548, 19, 3m, InterestPayment.EveryQuarter);

            Assert.IsNotNull(plan);
            Assert.AreEqual(7, plan.Incomes.Count());
            Assert.AreEqual(121.20m, plan.TotalIncome);
        }
    }
}
