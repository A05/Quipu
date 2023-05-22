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

            var plan = sut.Calculate(new Money(100, Currency.UAH), 12, 48m, InterestPayment.AtTheEndOfTerm);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(48.02m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);

            plan = sut.Calculate(new Money(2548, Currency.UAH), 19, 3m, InterestPayment.AtTheEndOfTerm);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(121.20m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);
        }
    }
}
