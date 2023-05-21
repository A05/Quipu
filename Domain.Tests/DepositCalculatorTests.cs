using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sx.Vx.Quipu.Domain
{
    // TODO: (U) make money class

    [TestClass]
    public class DepositCalculatorTests
    {
        [TestMethod]
        public void ShouldRound()
        {
            Assert.AreEqual(25.48m, new Money(25.48193m, Currency.UAH).Rounded);
            Assert.AreEqual(25.48m, new Money(25.48913m, Currency.UAH).Rounded);
            Assert.AreEqual(25.19m, new Money(25.19348m, Currency.UAH).Rounded);
            Assert.AreEqual(25.48m, new Money(25.485m, Currency.UAH).Rounded);
        }
    }
}
