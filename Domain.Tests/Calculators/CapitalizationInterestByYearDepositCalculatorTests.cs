using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    [TestClass]
    public class CapitalizationInterestByYearDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new CapitalizationInterestByYearDepositCalculator(null);

            var plan = sut.Calculate(new Money(100, Currency.UAH), 6, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(25.00m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);

            plan = sut.Calculate(new Money(100, Currency.UAH), 12, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(50.00m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);

            plan = sut.Calculate(new Money(150, Currency.UAH), 6, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(37.50m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);

            plan = sut.Calculate(new Money(100, Currency.UAH), 18, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(87.50m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);
        }
    }
}
