using Sx.Vx.Quipu.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Sx.Vx.Quipu.WinUI
{
    internal class CalculatorFormViewModelFactory
    {
        private readonly ILimitRepository _limitRepository;
        
        public CalculatorFormViewModelFactory(ILimitRepository limitRepository)
        {
            _limitRepository = limitRepository ?? throw new ArgumentNullException(nameof(limitRepository));
        }

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

            var currency = Currency.UAH;
            var limit = _limitRepository.Get(currency);

            var viewModel = new CalculatorFormViewModel()
            {
                Amount = limit.GetBeautifulAmount(),
                Term = limit.GetBeautifulTerm(),
                InterestRate = limit.GetBeautifulInterestRate(),
                CurrencyEntries = currencies,
                Currency = currency,
                ComboBoxCurrency = Currency.Empty,
                InterestPaymentEntries = interestPayments,
                InterestPayment = InterestPayment.EveryMonth
            };

            ApplyLimit(viewModel, limit);

            return viewModel;
        }

        public void ApplyLimit(CalculatorFormViewModel viewModel)
        {
            Debug.Assert(viewModel != null);

            var currency = viewModel.Currency;
            var limit = _limitRepository.Get(currency);

            viewModel.Amount = limit.ResolveAmount(viewModel.Amount);
            viewModel.Term = limit.ResolveTerm(viewModel.Term);
            viewModel.InterestRate = limit.ResolveInterestRate(viewModel.InterestRate);
            
            ApplyLimit(viewModel, limit);
        }

        private void ApplyLimit(CalculatorFormViewModel viewModel, Limit limit)
        {
            Debug.Assert(viewModel != null);

            var currency = viewModel.Currency;

            viewModel.MinAmount = limit.MinAmount;
            viewModel.MaxAmount = limit.MaxAmount;
            viewModel.AmountTickFrequency = limit.GetAmountTickFrequency();
            viewModel.MinAmountCaption = $"{limit.MinAmount:#,#} {currency.AlphabeticCode}";
            viewModel.MaxAmountCaption = $"{limit.MaxAmount:#,#} {currency.AlphabeticCode}";

            viewModel.MinTerm = limit.MinTerm;
            viewModel.MaxTerm = limit.MaxTerm;
            viewModel.TermTickFrequency = limit.GetTermTickFrequency();
            viewModel.MinTermCaption = $"{limit.MinTerm} mounths";
            viewModel.MaxTermCaption = $"{limit.MaxTerm} mounths";
            
            viewModel.MinInterestRate = limit.MinInterestRate;
            viewModel.MaxInterestRate = limit.MaxInterestRate;
            viewModel.InterestRateTickFrequency = limit.GetInterestRateTickFrequency();
            viewModel.MinInterestRateCaption = $"{limit.MinInterestRate} %";
            viewModel.MaxInterestRateCaption = $"{limit.MaxInterestRate} %";
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
