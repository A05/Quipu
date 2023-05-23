using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sx.Vx.Quipu.Domain;
using System;

namespace Sx.Vx.Quipu.WinUI
{
    [TestClass]
    public class LimitRepositoryTests
    {
        [TestMethod]
        public void ShouldBeLoaded()
        {
            var sut = LimitRepository.Load("ValidLimits.xml");
            Assert.IsNotNull(sut);

            var uah = sut.Get(Currency.UAH);
            Assert.AreEqual(10, uah.MinAmount);
            Assert.AreEqual(1000000, uah.MaxAmount);
            Assert.AreEqual(1, uah.MinTerm);
            Assert.AreEqual(64, uah.MaxTerm);
            Assert.AreEqual(14, uah.MinInterestRate);
            Assert.AreEqual(36, uah.MaxInterestRate);

            var usd = sut.Get(Currency.USD);
            Assert.AreEqual(100, usd.MinAmount);
            Assert.AreEqual(200000, usd.MaxAmount);
            Assert.AreEqual(3, usd.MinTerm);
            Assert.AreEqual(24, usd.MaxTerm);
            Assert.AreEqual(3, usd.MinInterestRate);
            Assert.AreEqual(18, usd.MaxInterestRate);

            var eur = sut.Get(Currency.EUR);
            Assert.AreEqual(100, eur.MinAmount);
            Assert.AreEqual(500000, eur.MaxAmount);
            Assert.AreEqual(3, eur.MinTerm);
            Assert.AreEqual(36, eur.MaxTerm);
            Assert.AreEqual(5, eur.MinInterestRate);
            Assert.AreEqual(24, eur.MaxInterestRate);

            foreach (var c in Currency.Currencies)
                if (c != Currency.UAH && c != Currency.USD && c != Currency.EUR)
                {
                    var @default = sut.Get(c);
                    Assert.AreEqual(10, @default.MinAmount);
                    Assert.AreEqual(10000, @default.MaxAmount);
                    Assert.AreEqual(1, @default.MinTerm);
                    Assert.AreEqual(36, @default.MaxTerm);
                    Assert.AreEqual(1, @default.MinInterestRate);
                    Assert.AreEqual(100, @default.MaxInterestRate);
                }
        }

        [TestMethod]
        public void ShouldBeLoadedManyTimes()
        {
            for (int i = 0; i < 3; i++)
            {
                var sut = LimitRepository.Load("ValidLimits.xml");
                Assert.IsNotNull(sut);
            }
        }

        [TestMethod]
        public void ShouldNotBeLoadedWithInvalidValues()
        {
            try { LimitRepository.Load("InvalidLimits1.xml"); Assert.Fail(); } catch (ApplicationException) {}
            try { LimitRepository.Load("InvalidLimits2.xml"); Assert.Fail(); } catch (ApplicationException) { }
            try { LimitRepository.Load("InvalidLimits3.xml"); Assert.Fail(); } catch (ApplicationException) { }
        }

        [TestMethod]
        public void ShouldNotBeLoadedWithoutDefault()
        {
            try { LimitRepository.Load("InvalidLimitsWithoutDefault.xml"); Assert.Fail(); } catch (ApplicationException) { }
        }

        [TestMethod]
        public void ShouldNotBeLoadedWithTwoDefaults()
        {
            try { LimitRepository.Load("InvalidLimitsWithTwoDefaults.xml"); Assert.Fail(); } catch (ApplicationException) { }
        }

        [TestMethod]
        public void ShouldNotBeLoadedWithInvalidCurrency()
        {
            try { LimitRepository.Load("InvalidLimitsWithBadCurrency.xml"); Assert.Fail(); } catch (NotSupportedException) { }
        }

        [TestMethod]
        public void ShouldBeFallbackableOnLoad()
        {
            var sut = LimitRepository.Load("NotExistingFile.xml", fallbackOnError: true);
            Assert.IsNotNull(sut);
        }
    }
}
