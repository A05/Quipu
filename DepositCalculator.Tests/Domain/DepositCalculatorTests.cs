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
            Assert.AreEqual(25.48m, DepositCalculator.Round(25.48193m));
            Assert.AreEqual(25.48m, DepositCalculator.Round(25.48913m));
            Assert.AreEqual(25.19m, DepositCalculator.Round(25.19348m));
            Assert.AreEqual(25.48m, DepositCalculator.Round(25.485m));
        }
    }
}
