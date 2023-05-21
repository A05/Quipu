using Sx.Vx.Quipu.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sx.Vx.Quipu.WinUI
{
    internal class CalculatorFormViewModel : INotifyPropertyChanged
    {
        #region Fields
        
        private int _amount;
        private int _minAmount;
        private int _maxAmount;
        private int _amountTickFrequency;
        private string _minAmountCaption;
        private string _maxAmountCaption;
        private KeyValuePair<int, string>[] _currencyEntries;
        private int _currencyCode;
        private int _term;
        private int _minTerm;
        private int _maxTerm;
        private int _termTickFrequency;
        private string _minTermCaption;
        private string _maxTermCaption;
        private int _interestRate;
        private int _minInterestRate;
        private int _maxInterestRate;
        private int _interestRateTickFrequency;
        private string _minInterestRateCaption;
        private string _maxInterestRateCaption;
        private KeyValuePair<InterestPayment, string>[] _interestPaymentEntries;
        private InterestPayment _interestPayment;
        private string _incomeDisplayValue;
        private readonly BindingList<KeyValuePair<DateTime, decimal>> _incomes = new BindingList<KeyValuePair<DateTime, decimal>>();

        #endregion

        #region Properties

        public int Amount
        {
            get => _amount;
            set
            {
                var old = _amount;
                _amount = value;
                if (old != _amount)
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(AmountDisplayValue));
                }
            }
        }

        public int MinAmount
        {
            get => _minAmount;
            set
            {
                var old = _minAmount;
                _minAmount = value;
                if (old != _minAmount)
                    OnPropertyChanged();
            }
        }

        public int MaxAmount
        {
            get => _maxAmount;
            set
            {
                var old = _maxAmount;
                _maxAmount = value;
                if (old != _maxAmount)
                    OnPropertyChanged();
            }
        }

        public int AmountTickFrequency
        {
            get => _amountTickFrequency;
            set
            {
                var old = _amountTickFrequency;
                _amountTickFrequency = value;
                if (old != _amountTickFrequency)
                    OnPropertyChanged();
            }
        }

        public string MinAmountCaption
        {
            get => _minAmountCaption;
            set
            {
                var old = _minAmountCaption;
                _minAmountCaption = value;
                if (old != _minAmountCaption)
                    OnPropertyChanged();
            }
        }

        public string MaxAmountCaption
        {
            get => _maxAmountCaption;
            set
            {
                var old = _maxAmountCaption;
                _maxAmountCaption = value;
                if (old != _maxAmountCaption)
                    OnPropertyChanged();
            }
        }

        public KeyValuePair<int, string>[] CurrencyEntries
        {
            get => _currencyEntries;
            set
            {
                Debug.Assert(_currencyEntries == null);

                _currencyEntries = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public int CurrencyCode
        {
            get => _currencyCode;
            set
            {
                var old = _currencyCode;
                _currencyCode = value;
                if (old != _currencyCode)
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(AmountDisplayValue));
                }
            }
        }

        public int Term
        {
            get => _term;
            set
            {
                var old = _term;
                _term = value;
                if (old != _term)
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TermDisplayValue));
                }
            }
        }

        public int MinTerm
        {
            get => _minTerm;
            set
            {
                var old = _minTerm;
                _minTerm = value;
                if (old != _minTerm)
                    OnPropertyChanged();
            }
        }

        public int MaxTerm
        {
            get => _maxTerm;
            set
            {
                var old = _maxTerm;
                _maxTerm = value;
                if (old != _maxTerm)
                    OnPropertyChanged();
            }
        }

        public int TermTickFrequency
        {
            get => _termTickFrequency;
            set
            {
                var old = _termTickFrequency;
                _termTickFrequency = value;
                if (old != _termTickFrequency)
                    OnPropertyChanged();
            }
        }

        public string MinTermCaption
        {
            get => _minTermCaption;
            set
            {
                var old = _minTermCaption;
                _minTermCaption = value;
                if (old != _minTermCaption)
                    OnPropertyChanged();
            }
        }

        public string MaxTermCaption
        {
            get => _maxTermCaption;
            set
            {
                var old = _maxTermCaption;
                _maxTermCaption = value;
                if (old != _maxTermCaption)
                    OnPropertyChanged();
            }
        }

        public int InterestRate
        {
            get => _interestRate;
            set
            {
                var old = _interestRate;
                _interestRate = value;
                if (old != _interestRate)
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(InterestRateDisplayValue));
                }
            }
        }

        public int MinInterestRate
        {
            get => _minInterestRate;
            set
            {
                var old = _minInterestRate;
                _minInterestRate = value;
                if (old != _minInterestRate)
                    OnPropertyChanged();
            }
        }

        public int MaxInterestRate
        {
            get => _maxInterestRate;
            set
            {
                var old = _maxInterestRate;
                _maxInterestRate = value;
                if (old != _maxInterestRate)
                    OnPropertyChanged();
            }
        }

        public int InterestRateTickFrequency
        {
            get => _interestRateTickFrequency;
            set
            {
                var old = _interestRateTickFrequency;
                _interestRateTickFrequency = value;
                if (old != _interestRateTickFrequency)
                    OnPropertyChanged();
            }
        }

        public string MinInterestRateCaption
        {
            get => _minInterestRateCaption;
            set
            {
                var old = _minInterestRateCaption;
                _minInterestRateCaption = value;
                if (old != _minInterestRateCaption)
                    OnPropertyChanged();
            }
        }

        public string MaxInterestRateCaption
        {
            get => _maxInterestRateCaption;
            set
            {
                var old = _maxInterestRateCaption;
                _maxInterestRateCaption = value;
                if (old != _maxInterestRateCaption)
                    OnPropertyChanged();
            }
        }

        public KeyValuePair<InterestPayment, string>[] InterestPaymentEntries
        {
            get => _interestPaymentEntries;
            set
            {
                Debug.Assert(_interestPaymentEntries == null);

                _interestPaymentEntries = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public InterestPayment InterestPayment
        {
            get => _interestPayment;
            set
            {
                var old = _interestPayment;
                _interestPayment = value;
                if (old != _interestPayment)
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(InterestPaymentDisplayValue));
                }
            }
        }

        public string AmountDisplayValue
        {
            get => $"{Amount} {CurrencyCode}";
        }

        public string TermDisplayValue
        {
            get => $"{Term} months";
        }

        public string InterestRateDisplayValue
        {
            get => $"{InterestRate} %";
        }

        public string InterestPaymentDisplayValue
        {
            get => _interestPaymentEntries.First(i => i.Key == InterestPayment).Value;
        }

        public string IncomeDisplayValue
        {
            get => _incomeDisplayValue;
            set
            {
                var old = _incomeDisplayValue;
                _incomeDisplayValue = value;
                if (old != _incomeDisplayValue)
                    OnPropertyChanged();
            }
        }

        public BindingList<KeyValuePair<DateTime, decimal>> Incomes => _incomes;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
