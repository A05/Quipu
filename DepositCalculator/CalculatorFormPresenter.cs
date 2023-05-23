using Sx.Vx.Quipu.Domain;
using Sx.Vx.Quipu.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Sx.Vx.Quipu.WinUI
{
    internal class CalculatorFormPresenter
    {
        private static readonly string[] InputProperties = new[]
        {
            nameof(CalculatorFormViewModel.Amount),
            nameof(CalculatorFormViewModel.Currency),
            nameof(CalculatorFormViewModel.Term),
            nameof(CalculatorFormViewModel.InterestRate),
            nameof(CalculatorFormViewModel.InterestPayment)
        };

        private readonly IDepositCalculator _calculator;
        private readonly CalculatorFormViewModel _viewModel;
        private readonly CalculatorFormViewModelFactory _viewModelFactory;
        private ICalculatorForm _view;

        public CalculatorFormPresenter(CalculatorFormViewModelFactory viewModelFactory, IDepositCalculatorFactory calculatorFactory)
        {
            if (viewModelFactory == null)
                throw new ArgumentNullException(nameof(viewModelFactory));

            if (calculatorFactory == null)
                throw new ArgumentNullException(nameof(calculatorFactory));

            _viewModelFactory = viewModelFactory;

            _calculator = calculatorFactory.Create();
            _viewModel = viewModelFactory.Create();
        }

        public void SetView(ICalculatorForm view)
        {
            Debug.Assert(_view == null);

            _view = view ?? throw new ArgumentNullException(nameof(view));

            CalculateIncomePlan(); // Fill the deposity income plan properties.

            _view.SetViewModel(_viewModel);
        }

        public void HandleLoadOnView()
        {
            Debug.Assert(_view != null);

            _viewModel.PropertyChanged += HandlePropertyChangedOnViewModel;
        }

        public bool IsAmountValid(string amount, out string error)
        {
            if (int.TryParse(amount, out var nxAmount))
                if (_viewModel.MinAmount <= nxAmount && nxAmount <= _viewModel.MaxAmount)
                {
                    error = string.Empty;
                    return true;
                }
            
            error = string.Format(Resources.AmountRangeError, _viewModel.MinAmount, _viewModel.MaxAmount);
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

            error = string.Format(Resources.TermRangeError, _viewModel.MinTerm, _viewModel.MaxTerm);
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

            error = string.Format(Resources.InterestRateRangeError, _viewModel.MinInterestRate, _viewModel.MaxInterestRate);
            return false;
        }

        private void HandlePropertyChangedOnViewModel(object sender, PropertyChangedEventArgs e)
        {
            if (InputProperties.Contains(e.PropertyName))
            {
                if (e.PropertyName == nameof(CalculatorFormViewModel.Currency))
                    _viewModelFactory.ApplyLimit(_viewModel);

                CalculateIncomePlan();
            }
        }

        private void CalculateIncomePlan()
        {
            var money = new Money(_viewModel.Amount, _viewModel.Currency);

            var plan = _calculator.Calculate(
                money,
                _viewModel.Term,
                _viewModel.InterestRate,
                _viewModel.InterestPayment);

            _viewModel.IncomeDisplayValue = plan.TotalIncome.ToString();
            
            _viewModel.Incomes.Clear();
            foreach (var (date, income) in plan.Incomes)
                _viewModel.Incomes.Add(new KeyValuePair<DateTime, Money>(date, income));
        }
    }
}
