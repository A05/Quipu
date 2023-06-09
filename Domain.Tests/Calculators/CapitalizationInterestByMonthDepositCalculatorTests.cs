﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain.Calculators
{
    [TestClass]
    public class CapitalizationInterestByMonthDepositCalculatorTests
    {
        [TestMethod]
        public void ShouldCalculate()
        {
            var sut = new CapitalizationInterestByMonthDepositCalculator(null);

            var plan = sut.Calculate(new Money(350000m, Currency.UAH), 9, 4.7m, InterestPayment.CapitalizationByMonth);

            Assert.IsNotNull(plan);
            Assert.AreEqual(1, plan.Incomes.Count());
            Assert.AreEqual(12532.56m, plan.TotalIncome);
            Assert.AreEqual(Currency.UAH, plan.TotalIncome.Currency);
        }
    }
}
