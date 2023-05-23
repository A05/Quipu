using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sx.Vx.Quipu.Domain;
using System.ComponentModel;

namespace Sx.Vx.Quipu.WinUI
{
    [TestClass]
    public class CalculatorFormViewModelTests
    {
        [TestMethod]
        public void ShouldBindAmountCaption()
        {
            var sut = new CalculatorFormViewModel { Currency = Currency.AED, MinAmount = 1, MaxAmount = 2 };
            var oldMinCaption = sut.MinAmountCaption;
            var oldMaxCaption = sut.MaxAmountCaption;

            sut.MinAmount = 10;
            Assert.AreNotEqual(oldMinCaption, sut.MinAmountCaption);
            sut.MinAmount = 1;
            Assert.AreEqual(oldMinCaption, sut.MinAmountCaption);

            sut.MaxAmount = 20;
            Assert.AreNotEqual(oldMaxCaption, sut.MaxAmountCaption);
            sut.MaxAmount = 2;
            Assert.AreEqual(oldMaxCaption, sut.MaxAmountCaption);

            sut.Currency = Currency.UAH;
            Assert.AreNotEqual(oldMinCaption, sut.MinAmountCaption);
            Assert.AreNotEqual(oldMaxCaption, sut.MaxAmountCaption);
            sut.Currency = Currency.AED;
            Assert.AreEqual(oldMinCaption, sut.MinAmountCaption);
            Assert.AreEqual(oldMaxCaption, sut.MaxAmountCaption);
        }

        [TestMethod]
        public void ShouldRaisePropertyChangedForAmountCaption()
        {
            var sut = new CalculatorFormViewModel { Currency = Currency.AED, MinAmount = 1, MaxAmount = 2 };
            
            bool isRaisedForMin = false;
            bool isRaisedForMax = false;
            sut.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
            {
                isRaisedForMin = isRaisedForMin || e.PropertyName == nameof(CalculatorFormViewModel.MinAmountCaption);
                isRaisedForMax = isRaisedForMax || e.PropertyName == nameof(CalculatorFormViewModel.MaxAmountCaption);
            };

            sut.MinAmount = 100;
            Assert.IsTrue(isRaisedForMin && !isRaisedForMax);

            isRaisedForMin = isRaisedForMax = false;
            sut.MaxAmount = 100;
            Assert.IsTrue(!isRaisedForMin && isRaisedForMax);

            isRaisedForMin = isRaisedForMax = false;
            sut.Currency = Currency.DJF;
            Assert.IsTrue(isRaisedForMin && isRaisedForMax);
        }

        [TestMethod]
        public void ShouldBindTermCaption()
        {
            var sut = new CalculatorFormViewModel { MinTerm = 1, MaxTerm = 2 };
            var oldMinCaption = sut.MinTermCaption;
            var oldMaxCaption = sut.MaxTermCaption;

            sut.MinTerm = 10;
            Assert.AreNotEqual(oldMinCaption, sut.MinTermCaption);
            sut.MinTerm = 1;
            Assert.AreEqual(oldMinCaption, sut.MinTermCaption);

            sut.MaxTerm = 20;
            Assert.AreNotEqual(oldMaxCaption, sut.MaxTermCaption);
            sut.MaxTerm = 2;
            Assert.AreEqual(oldMaxCaption, sut.MaxTermCaption);
        }

        [TestMethod]
        public void ShouldRaisePropertyChangedForTermCaption()
        {
            var sut = new CalculatorFormViewModel { MinTerm = 1, MaxTerm = 2 };

            bool isRaisedForMin = false;
            bool isRaisedForMax = false;
            sut.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
            {
                isRaisedForMin = isRaisedForMin || e.PropertyName == nameof(CalculatorFormViewModel.MinTermCaption);
                isRaisedForMax = isRaisedForMax || e.PropertyName == nameof(CalculatorFormViewModel.MaxTermCaption);
            };

            sut.MinTerm = 100;
            Assert.IsTrue(isRaisedForMin && !isRaisedForMax);

            isRaisedForMin = isRaisedForMax = false;
            sut.MaxTerm = 100;
            Assert.IsTrue(!isRaisedForMin && isRaisedForMax);
        }

        [TestMethod]
        public void ShouldBindInterestRateCaption()
        {
            var sut = new CalculatorFormViewModel { MinInterestRate = 1, MaxInterestRate = 2 };
            var oldMinCaption = sut.MinInterestRateCaption;
            var oldMaxCaption = sut.MaxInterestRateCaption;

            sut.MinInterestRate = 10;
            Assert.AreNotEqual(oldMinCaption, sut.MinInterestRateCaption);
            sut.MinInterestRate = 1;
            Assert.AreEqual(oldMinCaption, sut.MinInterestRateCaption);

            sut.MaxInterestRate = 20;
            Assert.AreNotEqual(oldMaxCaption, sut.MaxInterestRateCaption);
            sut.MaxInterestRate = 2;
            Assert.AreEqual(oldMaxCaption, sut.MaxInterestRateCaption);
        }

        [TestMethod]
        public void ShouldRaisePropertyChangedForInterestRateCaption()
        {
            var sut = new CalculatorFormViewModel { MinInterestRate = 1, MaxInterestRate = 2 };

            bool isRaisedForMin = false;
            bool isRaisedForMax = false;
            sut.PropertyChanged += (object sender, PropertyChangedEventArgs e) =>
            {
                isRaisedForMin = isRaisedForMin || e.PropertyName == nameof(CalculatorFormViewModel.MinInterestRateCaption);
                isRaisedForMax = isRaisedForMax || e.PropertyName == nameof(CalculatorFormViewModel.MaxInterestRateCaption);
            };

            sut.MinInterestRate = 100;
            Assert.IsTrue(isRaisedForMin && !isRaisedForMax);

            isRaisedForMin = isRaisedForMax = false;
            sut.MaxInterestRate = 100;
            Assert.IsTrue(!isRaisedForMin && isRaisedForMax);
        }
    }
}
