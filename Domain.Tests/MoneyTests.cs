using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Sx.Vx.Quipu.Domain
{
    [TestClass]
    public class MoneyTests
    {
        [TestMethod]
        public void ShouldBeConstructed()
        {
            var sut = new Money(2548.193m, Currency.ANG);
            
            Assert.AreEqual(2548.193m, sut.Amount);
            Assert.AreEqual(Currency.ANG, sut.Currency);
        }

        [TestMethod]
        public void ShouldByDefaultBeEmpty()
        {
            var sut = new Money();
            
            Assert.AreEqual(Money.Empty.Amount, sut.Amount);
            Assert.AreEqual(Money.Empty.Currency, sut.Currency);
        }

        [TestMethod]
        public void ShouldCreateNewMoney()
        {
            var sut = new Money(2548.193m, Currency.BZD);
            var @new = sut.New(4825.391m);

            Assert.AreEqual(4825.391m, @new.Amount);
            Assert.AreEqual(Currency.BZD, sut.Currency);
        }

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

        [TestMethod]
        public void ShouldBeEquatable()
        {
            Assert.IsFalse(Money.Empty.Equals(null));
            Assert.IsFalse(Money.Empty == null);

            var m1 = new Money(25, Currency.IDR);
            var m2 = new Money(25, Currency.IDR);
            var m3 = new Money(48, Currency.IDR);
            var m4 = new Money(25, Currency.OMR);

            Assert.IsTrue( m1.Equals(m2) && m1 == m2 &&  m1.Equals((object)m2));
            Assert.IsTrue(!m2.Equals(m3) && m2 != m3 && !m2.Equals((object)m3));
            Assert.IsTrue(!m2.Equals(m4) && m2 != m4 && !m2.Equals((object)m3));
        }

        [TestMethod]
        public void ShouldBeComparable()
        {
            var m1 = new Money(25, Currency.IDR);
            var m2 = new Money(25, Currency.IDR);

            Assert.IsTrue(m1.CompareTo(m2) == 0);
            Assert.IsTrue(m1 >= m2 && m1 <= m2 && m2 >= m1 && m2 >= m1);
            Assert.IsFalse(m1 < m2 && m2 < m1);

            var m3 = new Money(48, Currency.IDR);

            Assert.IsTrue(m2.CompareTo(m3) < 0);
            Assert.IsTrue(m3.CompareTo(m2) > 0);
            
            Assert.IsTrue(m2 <= m3 && m3 >= m2);
            Assert.IsFalse(m2 >= m3 || m3 <= m2);

            Assert.IsTrue(m2 < m3 && m3 > m2);
            Assert.IsFalse(m2 > m3 || m3 < m2);

            var m4 = new Money(25, Currency.OMR);

            try { var _ = m3.CompareTo(m4); Assert.Fail(); } catch (InvalidOperationException) { }
            try { var _ = m3 < m4; Assert.Fail(); } catch (InvalidOperationException) { }
            try { var _ = m3 > m4; Assert.Fail(); } catch (InvalidOperationException) { }
            try { var _ = m3 <= m4; Assert.Fail(); } catch (InvalidOperationException) { }
            try { var _ = m3 >= m4; Assert.Fail(); } catch (InvalidOperationException) { }
        }

        [TestMethod]
        public void ShouldBeHashable()
        {
            var m1 = new Money(25, Currency.IDR);
            var m2 = new Money(25, Currency.IDR);
            var m3 = new Money(48, Currency.IDR);
            var m4 = new Money(25, Currency.OMR);

            Assert.AreEqual(m1.GetHashCode(), m2.GetHashCode());
            Assert.AreNotEqual(m2.GetHashCode(), m3.GetHashCode());
            Assert.AreNotEqual(m2.GetHashCode(), m4.GetHashCode());
            Assert.AreNotEqual(m3.GetHashCode(), m4.GetHashCode());
        }

        [TestMethod]
        public void ShouldToStringForEmpty()
        {
            Assert.AreEqual("0", Money.Empty.ToString());
        }

        [TestMethod]
        public void ShouldToStringForNotEmpty()
        {
            var m1 = new Money(25.48m, Currency.UAH);
            
            Assert.IsTrue(Regex.IsMatch(m1.ToString(), "25.{1}48 UAH"));
        }

        [TestMethod]
        public void ShouldBeConvertableToDecimal()
        {
            var m1 = new Money(25.48m, Currency.UAH);

            decimal amount = m1;
            Assert.AreEqual(amount, m1.Amount);
        }

        [TestMethod]
        public void ShouldBeConvertableToDouble()
        {
            var m1 = new Money(25.48m, Currency.UAH);

            double amount = (double) m1;
            Assert.AreEqual(amount, (double) m1.Amount);
        }

        [TestMethod]
        public void ShouldBeConvertableFromDecimal()
        {
            decimal amount = 25.48m;

            var m1 = (Money)amount;
            Assert.AreEqual(amount, m1.Amount);
            Assert.AreEqual(Currency.Empty, m1.Currency);
        }
    }
}
