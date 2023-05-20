using Sx.Vx.Quipu.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Sx.Vx.Quipu.DepositCalculator
{
    internal class CalculatorFormPresenter
    {
        private static readonly string[] InputProperties = new[]
        {
            nameof(CalculatorFormViewModel.Amount),
            nameof(CalculatorFormViewModel.CurrencyCode),
            nameof(CalculatorFormViewModel.Term),
            nameof(CalculatorFormViewModel.InterestRate),
            nameof(CalculatorFormViewModel.InterestPayment)
        };

        private readonly IDepositCalculationApplicationService _service;
        private readonly CalculatorFormViewModel _viewModel;
        private CalculatorForm _view;

        public CalculatorFormPresenter(IDepositCalculationApplicationService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));

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

            _viewModel = new CalculatorFormViewModel()
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
                InterestPayment = InterestPayment.EveryMonth
            };

            CalculateIncomePlan();

            _viewModel.PropertyChanged += HandlePropertyChangedOnViewModel;
        }

        public void SetView(CalculatorForm view)
        {
            Debug.Assert(_view == null);

            _view = view ?? throw new ArgumentNullException(nameof(view));

            _view.SetViewModel(_viewModel);
        }

        public bool IsAmountValid(string amount, out string error)
        {
            if (int.TryParse(amount, out var nxAmount))
                if (_viewModel.MinAmount <= nxAmount && nxAmount <= _viewModel.MaxAmount)
                {
                    error = string.Empty;
                    return true;
                }
            
            error = $"Amount should be integer and be between {_viewModel.MinAmount} and {_viewModel.MaxAmount}.";
            return false;            
        }

        public bool IsTermValid(string term, out string error)
        {
            if (int.TryParse(term, out var nxTerm))
                if (_viewModel.MinTerm <= nxTerm && nxTerm <= _viewModel.MaxTerm)
                {
                    error = string.Empty;
                    return true;
                }

            error = $"Term should be integer and be between {_viewModel.MinTerm} and {_viewModel.MaxTerm}.";
            return false;
        }

        public bool IsInterestRateValid(string interestRate, out string error)
        {
            if (int.TryParse(interestRate, out var nxInterestRate))
                if (_viewModel.MinInterestRate <= nxInterestRate && nxInterestRate <= _viewModel.MaxInterestRate)
                {
                    error = string.Empty;
                    return true;
                }

            error = $"Term should be integer and be between {_viewModel.MinInterestRate} and {_viewModel.MaxInterestRate}.";
            return false;
        }

        private void HandlePropertyChangedOnViewModel(object sender, PropertyChangedEventArgs e)
        {
            if (InputProperties.Contains(e.PropertyName))
                CalculateIncomePlan();
        }

        private void CalculateIncomePlan()
        {
            var plan = _service.CalculateIncomePlan(
                _viewModel.Amount,
                _viewModel.Term,
                _viewModel.InterestRate,
                _viewModel.InterestPayment);

            _viewModel.IncomeDisplayValue = $"{plan.Income:.00} {_viewModel.CurrencyCode}";
        }
    }
}
