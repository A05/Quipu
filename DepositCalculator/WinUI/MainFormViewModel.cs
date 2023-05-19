using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    internal class MainFormViewModel : INotifyPropertyChanged
    {
        private readonly IEnumerable<KeyValuePair<int, string>> _currencyEntries;

        private int _amount;
        private int _minAmount;
        private int _maxAmount;
        private int _amountTickFrequency;
        private string _minAmountCaption;
        private string _maxAmountCaption;
        private int _currencyCode;
        private int _term;
        private int _minTerm;
        private int _maxTerm;
        private int _termTickFrequency;
        private string _minTermCaption;
        private string _maxTermCaption;

        public int Amount
        {
            get => _amount;
            set
            {
                var old = _amount;
                _amount = value;
                if (old != _amount)
                    OnPropertyChanged();
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

        public IEnumerable<KeyValuePair<int, string>> CurrencyEntries => _currencyEntries;

        public int CurrencyCode
        {
            get => _currencyCode;
            set
            {
                var old = _currencyCode;
                _currencyCode = value;
                if (old != _currencyCode)
                    OnPropertyChanged();
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
                    OnPropertyChanged();
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainFormViewModel(IEnumerable<KeyValuePair<int, string>> currencyEntries)
        {
            _currencyEntries = currencyEntries ?? throw new ArgumentNullException(nameof(currencyEntries));
        }
    }
}
