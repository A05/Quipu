using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Sx.Vx.Quipu.WinUI
{
    // TODO: (NU) Implement IXmlSerializable for the encapsulation.

    public class Limit
    {
        [XmlAttribute(AttributeName = "currency")]
        public string CurrencyAlphabeticCode;

        public int MinAmount;
        public int MaxAmount;
        public int MinTerm;
        public int MaxTerm;
        public int MinInterestRate;
        public int MaxInterestRate;

        public Limit() {}

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
            return $"{CurrencyAlphabeticCode}, A:{MinAmount}-{MaxAmount}, T:{MinTerm}-{MaxTerm}, IR:{MinInterestRate}-{MaxInterestRate}";
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
