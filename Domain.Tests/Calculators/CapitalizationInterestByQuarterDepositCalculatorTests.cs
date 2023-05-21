using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    [TestClass]
    public class CapitalizationInterestByQuarterDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new CapitalizationInterestByQuarterDepositCalculator(null);

            var plan = sut.Calculate(350000m, 9, 4.7m, InterestPayment.CapitalizationByQuarter);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(12483.03m, plan.TotalIncome);
        }
    }
}
