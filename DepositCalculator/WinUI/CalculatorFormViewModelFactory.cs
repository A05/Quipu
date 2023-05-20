using Sx.Vx.Quipu.Domain;
using System.Collections.Generic;

namespace Sx.Vx.Quipu.WinUI
{
    internal class CalculatorFormViewModelFactory
    {
        public CalculatorFormViewModel Create()
        {
            var currencies = new[]
            {
                new KeyValuePair<int, string>(1, "UAH"),
                new KeyValuePair<int, string>(2, "DLR"),
                new KeyValuePair<int, string>(3, "EUR")
            };

            var interestPayments = new[]
            {
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryMonth, "Every months"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryQuarter, "Every quater"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryYear, "Every year"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.AtTheEndOfTerm, "At the end of term"),
                new KeyValuePair<InterestPayment, string>(InterestPayment.Capitalization, "Capitalization")
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
                CurrencyCode = 3,
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
                InterestPayment = InterestPayment.AtTheEndOfTerm
            };

            return viewModel;
        }
    }
}
