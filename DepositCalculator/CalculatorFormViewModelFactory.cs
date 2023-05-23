using Sx.Vx.Quipu.Domain;
using Sx.Vx.Quipu.WinUI.Properties;
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
            var interestPayments = GetInterestPayments();

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

        public void ApplyResources(CalculatorFormViewModel viewModel)
        {
            viewModel.CurrencyEntries = GetCurrencies();
            viewModel.InterestPaymentEntries = GetInterestPayments();
        }

        private static KeyValuePair<InterestPayment, string>[] GetInterestPayments()
        {
            return new[]
            {
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryMonth, Resources.InterestPaymentEveryMonth),
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryQuarter, Resources.InterestPaymentEveryQuarter),
                new KeyValuePair<InterestPayment, string>(InterestPayment.EveryYear, Resources.InterestPaymentEveryYear),
                new KeyValuePair<InterestPayment, string>(InterestPayment.AtTheEndOfTerm, Resources.InterestPaymentAtTheEndOfTerm),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByDay, Resources.InterestPaymentCapitalizationByDay),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByMonth, Resources.InterestPaymentCapitalizationByMonth),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByQuarter, Resources.InterestPaymentCapitalizationByQuarter),
                new KeyValuePair<InterestPayment, string>(InterestPayment.CapitalizationByYear, Resources.InterestPaymentCapitalizationByYear)
            };
        }

        private void ApplyLimit(CalculatorFormViewModel viewModel, Limit limit)
        {
            Debug.Assert(viewModel != null);

            viewModel.MinAmount = limit.MinAmount;
            viewModel.MaxAmount = limit.MaxAmount;
            viewModel.AmountTickFrequency = limit.GetAmountTickFrequency();

            viewModel.MinTerm = limit.MinTerm;
            viewModel.MaxTerm = limit.MaxTerm;
            viewModel.TermTickFrequency = limit.GetTermTickFrequency();
            
            viewModel.MinInterestRate = limit.MinInterestRate;
            viewModel.MaxInterestRate = limit.MaxInterestRate;
            viewModel.InterestRateTickFrequency = limit.GetInterestRateTickFrequency();
        }

        private KeyValuePair<Currency, string>[] GetCurrencies()
        {
            var currencies = new KeyValuePair<Currency, string>[Currency.Currencies.Count() - 3 + 1];

            int i = 0;

            currencies[i++] = new KeyValuePair<Currency, string>(Currency.Empty, Resources.FirstCurrencyComboBoxItemName);

            foreach (var c in Currency.Currencies.OrderBy(_ => _))
                if (c == Currency.UAH || c == Currency.USD || c == Currency.EUR)
                    continue;
                else                
                    currencies[i++] = new KeyValuePair<Currency, string>(c, $"{c.AlphabeticCode} - {c.Name}");

            return currencies;
        }
    }
}
