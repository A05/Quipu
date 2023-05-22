using System;

namespace Sx.Vx.Quipu.WinUI
{    
    public class Limit
    {
        public int MinAmount { get; }
        public int MaxAmount { get; }
        public int MinTerm { get; }
        public int MaxTerm { get; }
        public int MinInterestRate { get; }
        public int MaxInterestRate { get; }

        public Limit(int minAmount, int maxAmount, int minTerm, int maxTerm, int minInterestRate, int maxInterestRate)
        {
            if (minAmount <= 0)
                throw new ArgumentException("Min amount must be greater than zero.", nameof(minAmount));

            if (maxAmount <= 0)
                throw new ArgumentException("Max amount must be greater than zero.", nameof(maxAmount));

            if (minTerm <= 0)
                throw new ArgumentException("Min term must be greater than zero.", nameof(minTerm));

            if (maxTerm <= 0)
                throw new ArgumentException("Max term must be greater than zero.", nameof(maxTerm));

            if (minInterestRate <= 0)
                throw new ArgumentException("Min interest rate must be greater than zero.", nameof(minInterestRate));

            if (maxInterestRate <= 0)
                throw new ArgumentException("Max interest rate must be greater than zero.", nameof(maxInterestRate));

            MinAmount = minAmount;
            MaxAmount = maxAmount;
            MinTerm = minTerm;
            MaxTerm = maxTerm;
            MinInterestRate = minInterestRate;
            MaxInterestRate = maxInterestRate;
        }

        public int GetBeautifulAmount() => GetBeautiful(MinAmount, MaxAmount);
        public int GetBeautifulTerm() => GetBeautiful(MinTerm, MaxTerm);
        public int GetBeautifulInterestRate() => GetBeautiful(MinInterestRate, MaxInterestRate);

        public int ResolveAmount(int oldValue) => Resolve(oldValue, MinAmount, MaxAmount);
        public int ResolveTerm(int oldValue) => Resolve(oldValue, MinTerm, MaxTerm);
        public int ResolveInterestRate(int oldValue) => Resolve(oldValue, MinInterestRate, MaxInterestRate);

        public int GetAmountTickFrequency() => GetTickFrequency(MinAmount, MaxAmount);
        public int GetTermTickFrequency() => GetTickFrequency(MinTerm, MaxTerm);
        public int GetInterestRateTickFrequency() => GetTickFrequency(MinInterestRate, MaxInterestRate);

        public override string ToString()
        {
            return $"A:{MinAmount}-{MaxAmount}, T:{MinTerm}-{MaxTerm}, IR:{MinInterestRate}-{MaxInterestRate}";
        }

        private int GetBeautiful(int min, int max)
        {
            var a = (int)(min + (max - min) * 0.25);

            for (int i = 0; true; i++)
                if (a % 10 == a)
                    return (a = (int)(a * Math.Pow(10, i))) < min ? min : a;
                else
                    a /= 10;
        }

        private int Resolve(int oldValue, int min, int max)
        {
            return oldValue < min ? min : oldValue > max ? max : oldValue;
        }

        private int GetTickFrequency(int min, int max)
        {
            return (max - min) / 15;
        }
    }
}
