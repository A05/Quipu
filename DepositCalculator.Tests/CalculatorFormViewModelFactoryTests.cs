using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sx.Vx.Quipu.WinUI
{
    [TestClass]
    public class CalculatorFormViewModelFactoryTests
    {
        [TestMethod]
        public void ShouldGetBeautifullAmount()
        {
            var sut = new Limit 
            {
                MinAmount = 14,
                MaxAmount = 36,
                MinTerm = 124,
                MaxTerm = 15345,
                MinInterestRate = 1344923,
                MaxInterestRate = 1536496545
            };

            var amount = sut.GetBeautifulAmount();
            Assert.AreEqual(14, amount);

            amount = sut.GetBeautifulTerm();
            Assert.AreEqual(3000, amount);

            amount = sut.GetBeautifulInterestRate();
            Assert.AreEqual(300000000, amount);
        }

        [TestMethod]
        public void ShouldResolveAmount()
        {
            var sut = new Limit
            {
                MinAmount = 1,
                MaxAmount = 10,
                MinTerm = 20,
                MaxTerm = 100,
                MinInterestRate = 20,
                MaxInterestRate = 100
            };

            var amount = sut.ResolveAmount(5);
            Assert.AreEqual(5, amount);

            amount = sut.ResolveTerm(10);
            Assert.AreEqual(20, amount);

            amount = sut.ResolveInterestRate(1056);
            Assert.AreEqual(100, amount);
        }
    }
}
