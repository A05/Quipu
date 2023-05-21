using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sx.Vx.Quipu.Domain
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void ShouldByDefaultBeEmpty()
        {
            Assert.AreEqual(Currency.Empty, new Currency());
        }

        [TestMethod]
        public void ShouldToStringForEmpty()
        {
            Assert.AreEqual("Empty", Currency.Empty.ToString());
        }

        [TestMethod]
        public void ShouldToStringForNotEmpty()
        {
            Assert.AreEqual("AED,784,2,United Arab Emirates dirham", Currency.AED.ToString());
        }

        [TestMethod]
        public void ShouldDefineCurrencies()
        {
            Assert.IsNotNull(Currency.Currencies);
            Assert.AreEqual(160, Currency.Currencies.Count());
        }

        [TestMethod]
        public void ShouldBeEquatable()
        {
            Assert.IsFalse(Currency.ETB.Equals(null));
            Assert.IsFalse(Currency.ETB == null);

            foreach (var c1 in Currency.Currencies)
            {
                Assert.AreNotEqual(Currency.Empty, c1);

                var equalsCount = 0;
                foreach (var c2 in Currency.Currencies)
                    if (c1 == c2)
                    {
                        Assert.IsTrue(c1.Equals(c2));
                        Assert.IsTrue(c1.Equals((object)c2));

                        equalsCount++;
                    }
                    else
                    {
                        Assert.IsFalse(c1.Equals(c2));
                        Assert.IsFalse(c1.Equals((object)c2));
                        Assert.IsTrue(c1 != c2);
                    }

                Assert.AreEqual(1, equalsCount);
            }
        }

        [TestMethod]
        public void ShouldBeComparable()
        {
            var sorted1 = Currency.Currencies.OrderBy(i => i).ToArray();
            var sorted2 = Currency.Currencies.OrderBy(i => i.AlphabeticCode).ToArray();

            Assert.AreEqual(sorted1.Length, sorted2.Length);

            for (var i = 0; i < sorted1.Length; i++)
            {
                Assert.AreEqual(sorted1[i], sorted2[i]);
                Assert.IsTrue(sorted1[i] <= sorted2[i]);
                Assert.IsTrue(sorted1[i] >= sorted2[i]);

                if (i != 0)
                {
                    Assert.IsTrue(sorted1[i - 1] < sorted1[i]);
                    Assert.IsTrue(sorted1[i - 1] <= sorted1[i]);
                    Assert.IsTrue(sorted1[i] > sorted1[i - 1]);
                    Assert.IsTrue(sorted1[i] >= sorted1[i - 1]);
                }
            }
        }

        [TestMethod]
        public void ShouldBeHashable()
        {
            foreach (var c in Currency.Currencies)
                Assert.AreEqual(c.NumericCode, c.GetHashCode());
        }
    }
}
