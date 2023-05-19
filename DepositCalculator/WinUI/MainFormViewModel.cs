using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    internal class MainFormViewModel : INotifyPropertyChanged
    {
        private readonly IEnumerable<(int code, string caption)> _currencies;

        private int _amount;
        private int _minAmount;
        private int _maxAmount;
        private int _tickFrequency;
        private string _minAmountCaption;
        private string _maxAmountCaption;        
        private int _currencyCode;

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

        public int TickFrequency
        {
            get => _tickFrequency;
            set
            {
                var old = _tickFrequency;
                _tickFrequency = value;
                if (old != _tickFrequency)
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

        public IEnumerable<(int code, string caption)> Currencies => _currencies;

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainFormViewModel(IEnumerable<(int code, string caption)> currencies)
        {
            _currencies = currencies ?? throw new ArgumentNullException(nameof(currencies));
        }
    }
}
