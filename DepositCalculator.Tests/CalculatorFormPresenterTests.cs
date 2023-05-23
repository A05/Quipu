using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sx.Vx.Quipu.Domain;
using System;
using System.Linq;

namespace Sx.Vx.Quipu.WinUI
{
    [TestClass]
    public class CalculatorFormPresenterTests
    {
        [TestMethod]
        public void ShouldSetViewModelOnSetView()
        {
            var limit = new Limit(1, 2, 4, 8, 16, 32);
            var limitRepository = Mock.Of<ILimitRepository>(o => 
                o.Get(It.IsAny<Currency>()) == limit);
            var modelFactory = new CalculatorFormViewModelFactory(limitRepository);

            var depositPlan = new DepositIncomePlan(Money.Empty, Enumerable.Empty<(DateTime, Money)>());
            var calculator = Mock.Of<IDepositCalculator>(o => 
                o.Calculate(
                    It.IsAny<Money>(), 
                    It.IsAny<int>(), 
                    It.IsAny<decimal>(), 
                    It.IsAny<InterestPayment>()) == depositPlan);
            var calculatorFactory = Mock.Of<IDepositCalculatorFactory>(o => 
                o.Create() == calculator);

            var sut = new CalculatorFormPresenter(modelFactory, calculatorFactory);

            var mView = new Mock<ICalculatorForm>();
            sut.SetView(mView.Object);

            mView.Verify(o => 
                o.SetViewModel(It.IsNotNull<CalculatorFormViewModel>()), Times.Once);
        }

        [TestMethod]
        public void ShouldCalculateIncomePlanOnViewModelChanged() 
        {
            var limit = new Limit(1, 2, 4, 8, 16, 32);
            var limitRepository = Mock.Of<ILimitRepository>(o => 
                o.Get(It.IsAny<Currency>()) == limit);
            var modelFactory = new CalculatorFormViewModelFactory(limitRepository);

            var depositPlan = new DepositIncomePlan(Money.Empty, Enumerable.Empty<(DateTime, Money)>());
            var mCalculator = new Mock<IDepositCalculator>();
            mCalculator.Setup(o => 
                o.Calculate(
                    It.IsAny<Money>(),
                    It.IsAny<int>(),
                    It.IsAny<decimal>(),
                    It.IsAny<InterestPayment>()))
                    .Returns(depositPlan);
            var calculatorFactory = Mock.Of<IDepositCalculatorFactory>(o => 
                o.Create() == mCalculator.Object);

            var sut = new CalculatorFormPresenter(modelFactory, calculatorFactory);

            CalculatorFormViewModel catchedVm = null;

            var mView = new Mock<ICalculatorForm>();
            mView.Setup(
                o => o.SetViewModel(It.IsAny<CalculatorFormViewModel>()))
                      .Callback((CalculatorFormViewModel vm) => { catchedVm = vm; });

            sut.SetView(mView.Object); // The first call to the calculator happans here.
            Assert.IsNotNull(catchedVm);

            sut.HandleLoadOnView(); // Required for subscribing to the PropertyChanged event.

            catchedVm.Amount++;
            mCalculator.Verify(o => 
                o.Calculate(It.IsAny<Money>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<InterestPayment>()), 
                Times.Exactly(2));

            catchedVm.Currency = Currency.AED;
            mCalculator.Verify(o =>
                o.Calculate(It.IsAny<Money>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<InterestPayment>()),
                Times.Exactly(3));

            catchedVm.Term++;
            mCalculator.Verify(o =>
                o.Calculate(It.IsAny<Money>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<InterestPayment>()),
                Times.Exactly(4));

            catchedVm.InterestRate++;
            mCalculator.Verify(o =>
                o.Calculate(It.IsAny<Money>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<InterestPayment>()),
                Times.Exactly(5));

            catchedVm.InterestPayment = InterestPayment.CapitalizationByYear;
            mCalculator.Verify(o =>
                o.Calculate(It.IsAny<Money>(), It.IsAny<int>(), It.IsAny<decimal>(), It.IsAny<InterestPayment>()),
                Times.Exactly(6));
        }
    }
}
