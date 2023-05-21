using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

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
        public void ShouldCreateCalculatorForEachInterestPayment()
        {
            var sut = new DepositCalculatorFactory();

            var calculator = sut.Create();

            foreach (var interestPayment in Enum.GetValues(typeof(InterestPayment)).Cast<InterestPayment>())
            {
                if (interestPayment != InterestPayment.Unknown)
                {
                    var plan = calculator.Calculate(new Money(100, Currency.UAH), 12, 48m, interestPayment);

                    Assert.IsNotNull(plan);
                }
            }
        }
    }
}
