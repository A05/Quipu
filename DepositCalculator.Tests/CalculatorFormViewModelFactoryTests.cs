using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sx.Vx.Quipu.Domain;

namespace Sx.Vx.Quipu.WinUI
{
    [TestClass]
    public class CalculatorFormViewModelFactoryTests
    {
        [TestMethod]
        public void ShouldCreateViewModel()
        {
            var l = new Limit(1, 2, 4, 8, 16, 32);
            var lr = Mock.Of<ILimitRepository>(o => o.Get(It.IsAny<Currency>()) == l);

            var sut = new CalculatorFormViewModelFactory(lr);

            var vm = sut.Create();

            Assert.IsNotNull(vm);
            Assert.IsNotNull(vm.CurrencyEntries);            
            Assert.AreNotEqual(Currency.Empty, vm.Currency);
            Assert.IsNotNull(vm.InterestPaymentEntries);
            Assert.AreNotEqual(InterestPayment.Unknown, vm.Currency);
        }

        [TestMethod]
        public void ShouldApplyLimits()
        {
            var defLimit = new Limit(1, 20, 40, 80, 160, 320);
            var aedLimit = new Limit(1, 25, 45, 85, 165, 325);

            var lrm = new Mock<ILimitRepository>();
            lrm.Setup(o => o.Get(It.IsNotIn(Currency.AED))).Returns(defLimit);
            lrm.Setup(o => o.Get(It.IsIn(Currency.AED))).Returns(aedLimit);

            var sut = new CalculatorFormViewModelFactory(lrm.Object);
            var vm = sut.Create();

            Assert.AreEqual(1, vm.MinAmount);
            Assert.AreEqual(20, vm.MaxAmount);
            Assert.AreEqual(40, vm.MinTerm);
            Assert.AreEqual(80, vm.MaxTerm);
            Assert.AreEqual(160, vm.MinInterestRate);
            Assert.AreEqual(320, vm.MaxInterestRate);

            vm.Currency = Currency.AED;
            vm.Amount = 10;
            vm.Term = 50;
            vm.InterestRate = 220;

            sut.ApplyLimit(vm);

            Assert.AreEqual(10, vm.Amount);
            Assert.AreEqual(50, vm.Term);
            Assert.AreEqual(220, vm.InterestRate);

            Assert.AreEqual(1, vm.MinAmount);
            Assert.AreEqual(25, vm.MaxAmount);
            Assert.AreEqual(45, vm.MinTerm);
            Assert.AreEqual(85, vm.MaxTerm);
            Assert.AreEqual(165, vm.MinInterestRate);
            Assert.AreEqual(325, vm.MaxInterestRate);            
        }
    }
}
