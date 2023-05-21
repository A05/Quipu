using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sx.Vx.Quipu.Domain
{
    [TestClass]
    public class DepositCalculatorFactoryTests
    {
        [TestMethod]
        public void ShouldCreate()
        {
            var sut = new DepositCalculatorFactory();

            Assert.IsNotNull(sut.Create());
        }

        [TestMethod]
        public void ShouldCalculateTheSameTotalIncomeWithSimplePercent()
        {
            var factory = new DepositCalculatorFactory();
            var sut = factory.Create();

            var interestPayments = new[]
            {
                InterestPayment.EveryMonth,
                InterestPayment.EveryQuarter,
                InterestPayment.EveryYear,
                InterestPayment.AtTheEndOfTerm
            };

            decimal? expTotalIncome1 = null, expTotalIncome2 = null;

            foreach (var interestPayment in interestPayments)
            {
                var plan = sut.Calculate(100, 12, 48m, interestPayment);

                expTotalIncome1 = expTotalIncome1 ?? (expTotalIncome1 = plan.TotalIncome);

                Assert.IsNotNull(plan);
                Assert.AreEqual(expTotalIncome1, plan.TotalIncome);

                plan = sut.Calculate(2548, 19, 3m, interestPayment);

                expTotalIncome2 = expTotalIncome2 ?? (expTotalIncome2 = plan.TotalIncome);

                Assert.IsNotNull(plan);
                Assert.AreEqual(expTotalIncome2, plan.TotalIncome);
            }
        }
    }
}
