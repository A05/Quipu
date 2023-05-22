using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    [TestClass]
    public class CapitalizationInterestByDayDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new CapitalizationInterestByDayDepositCalculator(null);

            var plan = sut.Calculate(new Money(350000m, Currency.UAH), 9, 4.7m, InterestPayment.CapitalizationByDay);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(12654.86m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);
        }
    }
}
