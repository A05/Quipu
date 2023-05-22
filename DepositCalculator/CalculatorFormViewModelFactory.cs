using Sx.Vx.Quipu.Domain;
using System.Collections.Generic;
using System.Linq;

namespace Sx.Vx.Quipu.WinUI
{
    internal class CalculatorFormViewModelFactory
    {
        public CalculatorFormViewModel Create()
        {
            var currencies = GetCurrencies();

            var interestPayments = new[]
            {
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryMonth, "Every months"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryQuarter, "Every quater"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryYear, "Every year"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.AtTheEndOfTerm, "At the end of term"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByDay, "C12n by day"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByMonth, "C12n by month"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByQuarter, "C12n by quarter"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByYear, "C12n by year")
            };

            var viewModel = new CalculatorFormViewModel()
            {
                Amount = 25,
                MinAmount = 10,
                MaxAmount = 100,
                AmountTickFrequency = (100 - 10) / 15,
                MinAmountCaption = $"{10} $",
                MaxAmountCaption = $"{100} $",
                CurrencyEntries = currencies,
                Currency = Currency.UAH,
                ComboBoxCurrency = Currency.Empty,
                Term = 12,
                MinTerm = 3,
                MaxTerm = 64,
                TermTickFrequency = (64 - 3) / 15,
                MinTermCaption = $"{3} mounths",
                MaxTermCaption = $"{64} mounths",
                InterestRate = 24,
                MinInterestRate = 1,
                MaxInterestRate = 100,
                InterestRateTickFrequency = (100 - 1) / 15,
                MinInterestRateCaption = $"{1} %",
                MaxInterestRateCaption = $"{100} %",
                InterestPaymentEntries = interestPayments,
                InterestPayment = InterestPayment.EveryMonth
            };

            return viewModel;
        }

        private KeyValuePair<Currency, string>[] GetCurrencies()
        {
            var currencies = new KeyValuePair<Currency, string>[Currency.Currencies.Count() - 3 + 1];

            int i = 0;

            currencies[i++] = new KeyValuePair<Currency, string>(Currency.Empty, "More...");

            foreach (var c in Currency.Currencies.OrderBy(_ => _))
                if (c == Currency.UAH || c == Currency.USD || c == Currency.EUR)
                    continue;
                else                
                    currencies[i++] = new KeyValuePair<Currency, string>(c, $"{c.AlphabeticCode} - {c.Name}");

            return currencies;
        }
    }
}
