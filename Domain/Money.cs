using System;

namespace Sx.Vx.Quipu.Domain
{
    public struct Money : IEquatable<Money>, IComparable<Money>
    {
        public static readonly Money Empty = new Money();

        private string _toString;

        public decimal Amount { get; }
        public Currency Currency { get; }

        public Money Rounded => new Money(GetRoundedAmount(), Currency);

        public Money(decimal amount, Currency currency) : this()
        {
            Amount = amount;
            Currency = currency;
        }

        public Money New(decimal amount) => new Money(amount, Currency);

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
            AssertCurrenciesAreTheSame(this, other);

            return Amount.CompareTo(other.Amount);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode() ^ Currency.GetHashCode();
        }

        public override string ToString()
        {
            if (_toString == null)
                if (this == Empty)
                    _toString = "0";
                else
                    _toString = $"{GetRoundedAmount():#,#.00} {Currency.AlphabeticCode ?? string.Empty}";

            return _toString;
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

        public static Money operator +(Money m1, Money m2)
        {
            AssertCurrenciesAreTheSame(m1, m2);

            return new Money(m1.Amount + m2.Amount, m1.Currency);
        }

        public static Money operator -(Money m1, Money m2)
        {
            AssertCurrenciesAreTheSame(m1, m2);

            return new Money(m1.Amount - m2.Amount, m1.Currency);
        }

        public static implicit operator decimal(Money m) => m.Amount;
        public static explicit operator double(Money m) => (double) m.Amount;

        public static explicit operator Money(decimal amount) => new Money(amount, Currency.Empty);
        
        private decimal GetRoundedAmount()
        {
            var precision = (int) Math.Pow(10, Currency.Precision);
            var amount = Math.Truncate(Amount * precision) / precision;

            return amount;
        }

        private static void AssertCurrenciesAreTheSame(Money m1, Money m2)
        {
            if (m1.Currency.CompareTo(m2.Currency) != 0)
                throw new InvalidOperationException();
        }
    }
}
