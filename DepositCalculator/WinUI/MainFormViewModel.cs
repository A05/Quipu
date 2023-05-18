using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    internal class MainFormViewModel : INotifyPropertyChanged
    {
        private int _amount;
        private int _minAmount;
        private int _maxAmount;
        private int _tickFrequency;
        private string _minAmountCaption;
        private string _maxAmountCaption;

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
