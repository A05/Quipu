using System;

namespace Sx.Vx.Quipu.Domain
{
    public struct Money : IEquatable<Money>, IComparable<Money>
    {
        public static readonly Money Empty = new Money();

        private string _toString;

        public decimal Amount { get; }
        public Currency Currency { get; }

        public Money Zero => new Money(decimal.Zero, Currency);
        public Money Rounded => new Money(GetRoundedAmount(), Currency);

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
            if (Currency.CompareTo(other.Currency) != 0)
                throw new InvalidOperationException();

            return Amount.CompareTo(other.Amount);
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

        public static implicit operator decimal(Money m) => m.Amount;
        public static explicit operator double(Money m) => (double) m.Amount;

        public static explicit operator Money(decimal amount) => new Money(amount, Currency.Empty);

        public Money Get(decimal amount) => new Money(amount, Currency);

        private decimal GetRoundedAmount()
        {
            var precision = (int) Math.Pow(10, Currency.Precision);
            var amount = Math.Truncate(Amount * precision) / precision;

            return amount;
        }
    }
}
