using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sx.Vx.Quipu.WinUI
{
    [TestClass]
    public class LimitTests
    {
        [TestMethod]
        public void ShouldSetProperties()
        {
            var sut = new Limit(1, 2, 4, 8, 16, 32);

            Assert.AreEqual(1, sut.MinAmount);
            Assert.AreEqual(2, sut.MaxAmount);
            Assert.AreEqual(4, sut.MinTerm);
            Assert.AreEqual(8, sut.MaxTerm);
            Assert.AreEqual(16, sut.MinInterestRate);
            Assert.AreEqual(32, sut.MaxInterestRate);
        }

        [TestMethod]
        public void ShouldThrowForInvalidValues()
        {
            assertThrow(() => new Limit(0, 2, 4, 8, 16, 32), "minAmount");
            assertThrow(() => new Limit(1, 0, 4, 8, 16, 32), "maxAmount");
            assertThrow(() => new Limit(1, 2, 0, 8, 16, 32), "minTerm");
            assertThrow(() => new Limit(1, 2, 4, 0, 16, 32), "maxTerm");
            assertThrow(() => new Limit(1, 2, 4, 8, 0, 32), "minInterestRate");
            assertThrow(() => new Limit(1, 2, 4, 8, 16, 0), "maxInterestRate");

            assertThrow(() => new Limit(-1, 2, 4, 8, 16, 32), "minAmount");
            assertThrow(() => new Limit(1, -1, 4, 8, 16, 32), "maxAmount");
            assertThrow(() => new Limit(1, 2, -1, 8, 16, 32), "minTerm");
            assertThrow(() => new Limit(1, 2, 4, -1, 16, 32), "maxTerm");
            assertThrow(() => new Limit(1, 2, 4, 8, -1, 32), "minInterestRate");
            assertThrow(() => new Limit(1, 2, 4, 8, 16, -1), "maxInterestRate");

            void assertThrow(Action createLimit, string paramName)
            {
                try 
                { 
                    createLimit(); 
                    Assert.Fail(); 
                } 
                catch (ArgumentException ex) 
                { 
                    Assert.AreEqual(paramName, ex.ParamName); 
                }
            }
        }

        [TestMethod]
        public void ShouldGetBeautifullNumbers()
        {
            var sut = new Limit(
                minAmount: 14,
                maxAmount: 36,
                minTerm: 124,
                maxTerm: 15345,
                minInterestRate: 1344923,
                maxInterestRate: 1536496545
            );

            var amount = sut.GetBeautifulAmount();
            Assert.AreEqual(14, amount);

            amount = sut.GetBeautifulTerm();
            Assert.AreEqual(3000, amount);

            amount = sut.GetBeautifulInterestRate();
            Assert.AreEqual(300000000, amount);
        }

        [TestMethod]
        public void ShouldResolveNumbers()
        {
            var sut = new Limit(
                minAmount: 1,
                maxAmount: 10,
                minTerm: 20,
                maxTerm: 100,
                minInterestRate: 20,
                maxInterestRate: 100
            );

            var amount = sut.ResolveAmount(5);
            Assert.AreEqual(5, amount);

            amount = sut.ResolveTerm(10);
            Assert.AreEqual(20, amount);

            amount = sut.ResolveInterestRate(1056);
            Assert.AreEqual(100, amount);
        }
    }
}
