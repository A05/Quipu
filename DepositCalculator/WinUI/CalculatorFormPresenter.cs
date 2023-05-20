﻿using Sx.Vx.Quipu.Domain;
using System;
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
            nameof(CalculatorFormViewModel.CurrencyCode),
            nameof(CalculatorFormViewModel.Term),
            nameof(CalculatorFormViewModel.InterestRate),
            nameof(CalculatorFormViewModel.InterestPayment)
        };

        private readonly DepositCalculator _calculator;
        private readonly CalculatorFormViewModel _viewModel;
        private CalculatorForm _view;

        public CalculatorFormPresenter(CalculatorFormViewModelFactory viewModelFactory, DepositCalculatorFactory calculatorFactory)
        {
            if (viewModelFactory == null)
                throw new ArgumentNullException(nameof(viewModelFactory));

            if (calculatorFactory == null)
                throw new ArgumentNullException(nameof(calculatorFactory));
            
            _calculator = calculatorFactory.Create();
            _viewModel = viewModelFactory.Create();            
        }

        public void SetView(CalculatorForm view)
        {
            Debug.Assert(_view == null);

            _view = view ?? throw new ArgumentNullException(nameof(view));

            CalculateIncomePlan(); // Fill the deposity income plan properties.

            _view.SetViewModel(_viewModel);

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
            var plan = _calculator.Calculate(
                _viewModel.Amount,
                _viewModel.Term,
                _viewModel.InterestRate,
                _viewModel.InterestPayment);

            _viewModel.IncomeDisplayValue = $"{plan.TotalIncome:.00} {_viewModel.CurrencyCode}";
        }
    }
}
