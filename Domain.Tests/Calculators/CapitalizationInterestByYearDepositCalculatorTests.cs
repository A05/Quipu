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

            var plan = sut.Calculate(100, 6, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(25.00m, plan.TotalIncome);

            plan = sut.Calculate(100, 12, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(50.00m, plan.TotalIncome);

            plan = sut.Calculate(150, 6, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(37.50m, plan.TotalIncome);

            plan = sut.Calculate(100, 18, 50m, InterestPayment.CapitalizationByYear);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(87.50m, plan.TotalIncome);
        }
    }
}
