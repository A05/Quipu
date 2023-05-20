using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sx.Vx.Quipu.Domain
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void ShouldRound()
        {
            Assert.AreEqual(0, Currency.BIF.Precision);

            Assert.AreEqual(25m, new Money(25.48193m, Currency.BIF).Rounded);
            Assert.AreEqual(25m, new Money(25.48913m, Currency.BIF).Rounded);
            Assert.AreEqual(25m, new Money(25.19348m, Currency.BIF).Rounded);
            Assert.AreEqual(25m, new Money(25.485m, Currency.BIF).Rounded);

            Assert.AreEqual(2, Currency.UAH.Precision);

            Assert.AreEqual(25.48m, new Money(25.48193m, Currency.UAH).Rounded);
            Assert.AreEqual(25.48m, new Money(25.48913m, Currency.UAH).Rounded);
            Assert.AreEqual(25.19m, new Money(25.19348m, Currency.UAH).Rounded);
            Assert.AreEqual(25.48m, new Money(25.485m, Currency.UAH).Rounded);

            Assert.AreEqual(3, Currency.BHD.Precision);

            Assert.AreEqual(25.481m, new Money(25.48193m, Currency.BHD).Rounded);
            Assert.AreEqual(25.489m, new Money(25.48913m, Currency.BHD).Rounded);
            Assert.AreEqual(25.193m, new Money(25.19348m, Currency.BHD).Rounded);
            Assert.AreEqual(25.485m, new Money(25.485m, Currency.BHD).Rounded);

            Assert.AreEqual(4, Currency.UYW.Precision);

            Assert.AreEqual(25.4819m, new Money(25.48193m, Currency.UYW).Rounded);
            Assert.AreEqual(25.4891m, new Money(25.48913m, Currency.UYW).Rounded);
            Assert.AreEqual(25.1934m, new Money(25.19348m, Currency.UYW).Rounded);
            Assert.AreEqual(25.4858m, new Money(25.48589m, Currency.UYW).Rounded);
        }
    }
}
