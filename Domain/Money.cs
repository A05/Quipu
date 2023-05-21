using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sx.Vx.Quipu.Domain
{
    public struct Money : IEquatable<Money>, IComparable<Money>
    {
        public static readonly Money Empty = new Money();

        private string _toString;

        public decimal Amount { get; }

        public Currency Currency { get; }

        public Money(decimal amount, Currency currency) : this()
        {
            Amount = amount;
            Currency = currency;
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is Money other && Equals(other);
        }

        public bool Equals(Money other)
        {
            return Amount == other.Amount && Currency == other.Currency;
        }

        public int CompareTo(Money other)
        {
            var r = Currency.CompareTo(other.Currency);
            return r == 0 ? Amount.CompareTo(other.Amount) : r;
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Equals(m2);
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return !m1.Equals(m2);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() ^ Currency.GetHashCode();
        }

        public override string ToString()
        {
            return _toString ?? (_toString = $"{GetRoundedAmount()} {Currency.AlphabeticCode}");
        }

        private decimal GetRoundedAmount()
        {
            var precision = (int) Math.Pow(10, Currency.Precision);
            return Math.Truncate(Amount * precision) / precision;
        }
    }
}
