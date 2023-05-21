using System;

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

        public override int GetHashCode()
        {
            return Amount.GetHashCode() ^ Currency.GetHashCode();
        }

        public override string ToString()
        {
            return _toString ?? (_toString = $"{GetRoundedAmount()} {Currency.AlphabeticCode}");
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Equals(m2);
        }

        public static bool operator !=(Money m1, Money m2)
        {
            return !m1.Equals(m2);
        }

        public static bool operator >(Money m1, Money m2)
        {
            return m1.CompareTo(m2) > 0;
        }

        public static bool operator <(Money m1, Money m2)
        {
            return m1.CompareTo(m2) < 0;
        }

        public static bool operator >=(Money m1, Money m2)
        {
            return m1.CompareTo(m2) >= 0;
        }

        public static bool operator <=(Money m1, Money m2)
        {
            return m1.CompareTo(m2) <= 0;
        }

        public Money Round()
        {
            var amount = GetRoundedAmount();
            var money = new Money(amount, Currency);
            
            return money;
        }

        private decimal GetRoundedAmount()
        {
            var precision = (int) Math.Pow(10, Currency.Precision);
            var amount = Math.Truncate(Amount * precision) / precision;

            return amount;
        }
    }
}
