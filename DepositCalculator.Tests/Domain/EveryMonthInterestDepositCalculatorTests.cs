using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain
{
    [TestClass]
    public class EveryMonthInterestDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new EveryMonthInterestDepositCalculator(null);

            var plan = sut.Calculate(100, 12, 48m, InterestPayment.EveryMonth);

            Assert.IsNotNull(plan);
            Assert.AreEqual(12, plan.Incomes.Count());
            Assert.AreEqual(48.02m, plan.TotalIncome);

            plan = sut.Calculate(2548, 19, 3m, InterestPayment.EveryMonth);

            Assert.IsNotNull(plan);
            Assert.AreEqual(19, plan.Incomes.Count());
            Assert.AreEqual(121.20m, plan.TotalIncome);
        }
    }
}
