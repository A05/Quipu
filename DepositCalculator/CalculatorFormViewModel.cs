﻿using Sx.Vx.Quipu.Domain;
using Sx.Vx.Quipu.WinUI.Properties;
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
        private KeyValuePair<Currency, string>[] _currencyEntries;
        private Currency _currency;
        private Currency _comboBoxCurrency;
        private int _term;
        private int _minTerm;
        private int _maxTerm;
        private int _termTickFrequency;
        private int _interestRate;
        private int _minInterestRate;
        private int _maxInterestRate;
        private int _interestRateTickFrequency;
        private KeyValuePair<InterestPayment, string>[] _interestPaymentEntries;
        private InterestPayment _interestPayment;
        private string _incomeDisplayValue;
        private readonly BindingList<KeyValuePair<DateTime, Money>> _incomes = new BindingList<KeyValuePair<DateTime, Money>>();

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
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(MinAmountCaption));
                }
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
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(MaxAmountCaption));
                }
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
            get => $"{MinAmount:#,#} {Currency.AlphabeticCode}";
        }

        public string MaxAmountCaption
        {
            get => $"{MaxAmount:#,#} {Currency.AlphabeticCode}";
        }

        public KeyValuePair<Currency, string>[] CurrencyEntries
        {
            get => _currencyEntries;
            set
            {
                _currencyEntries = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public Currency Currency
        {
            get => _currency;
            set
            {
                var old = _currency;
                _currency = value;
                if (old != _currency)
                {
                    _comboBoxCurrency = Currency.Empty;

                    OnPropertyChanged();

                    OnPropertyChanged(nameof(ComboBoxCurrency));

                    OnPropertyChanged(nameof(IsUahRadioButtonChecked));
                    OnPropertyChanged(nameof(IsUsdRadioButtonChecked));
                    OnPropertyChanged(nameof(IsEurRadioButtonChecked));

                    OnPropertyChanged(nameof(MinAmountCaption));
                    OnPropertyChanged(nameof(MaxAmountCaption));

                    OnPropertyChanged(nameof(AmountDisplayValue));
                }
            }
        }

        public Currency ComboBoxCurrency
        {
            get => _comboBoxCurrency;
            set
            {
                var old = _comboBoxCurrency;
                _comboBoxCurrency = value;
                if (old != _comboBoxCurrency)
                {
                    if (_comboBoxCurrency == Currency.Empty)
                        _currency = Currency.UAH;
                    else
                        _currency = _comboBoxCurrency;

                    OnPropertyChanged();

                    OnPropertyChanged(nameof(Currency));

                    OnPropertyChanged(nameof(IsUahRadioButtonChecked));
                    OnPropertyChanged(nameof(IsUsdRadioButtonChecked));
                    OnPropertyChanged(nameof(IsEurRadioButtonChecked));

                    OnPropertyChanged(nameof(AmountDisplayValue));
                }
            }
        }

        public bool IsUahRadioButtonChecked
        {
            get => Currency == Currency.UAH;
        }

        public bool IsUsdRadioButtonChecked
        {
            get => Currency == Currency.USD;
        }

        public bool IsEurRadioButtonChecked
        {
            get => Currency == Currency.EUR;
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
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(MinTermCaption));
                }
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
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(MaxTermCaption));
                }
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
            get => $"{MinTerm} {Resources.TermCaptionSuffix}";
        }

        public string MaxTermCaption
        {
            get => $"{MaxTerm} {Resources.TermCaptionSuffix}";
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
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(MinInterestRateCaption));
                }
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
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(MaxInterestRateCaption));
                }
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
            get => $"{MinInterestRate} %";
        }

        public string MaxInterestRateCaption
        {
            get => $"{MaxInterestRate} %";
        }

        public KeyValuePair<InterestPayment, string>[] InterestPaymentEntries
        {
            get => _interestPaymentEntries;
            set
            {
                _interestPaymentEntries = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
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

                    OnPropertyChanged(nameof(IsEveryMonthRadioButtonChecked));
                    OnPropertyChanged(nameof(IsEveryQuarterRadioButtonChecked));
                    OnPropertyChanged(nameof(IsEveryYearRadioButtonChecked));
                    OnPropertyChanged(nameof(IsAtTheEndOfTermRadioButtonChecked));

                    OnPropertyChanged(nameof(IsCapitalizationByDayRadioButtonChecked));
                    OnPropertyChanged(nameof(IsCapitalizationByMonthRadioButtonChecked));
                    OnPropertyChanged(nameof(IsCapitalizationByQuarterRadioButtonChecked));
                    OnPropertyChanged(nameof(IsCapitalizationByYearRadioButtonChecked));

                    OnPropertyChanged(nameof(InterestPaymentDisplayValue));
                }
            }
        }

        public bool IsEveryMonthRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.EveryMonth;
        }

        public bool IsEveryQuarterRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.EveryQuarter;
        }

        public bool IsEveryYearRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.EveryYear;
        }

        public bool IsAtTheEndOfTermRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.AtTheEndOfTerm;
        }

        public bool IsCapitalizationByDayRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.CapitalizationByDay;
        }

        public bool IsCapitalizationByMonthRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.CapitalizationByMonth;
        }

        public bool IsCapitalizationByQuarterRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.CapitalizationByQuarter;
        }

        public bool IsCapitalizationByYearRadioButtonChecked
        {
            get => InterestPayment == InterestPayment.CapitalizationByYear;
        }

        public string AmountDisplayValue
        {
            get => $"{Amount:#,#} {Currency.AlphabeticCode}";
        }

        public string TermDisplayValue
        {
            get => $"{Term} {Resources.TermCaptionSuffix}";
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

        public BindingList<KeyValuePair<DateTime, Money>> Incomes => _incomes;

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
