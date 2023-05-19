using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    internal class MainFormPresenter
    {
        private MainForm _view;
        private readonly MainFormViewModel _viewModel;

        public MainFormPresenter()
        {
            var currencies = new[]
            {
                new KeyValuePair<int, string>(1, "UAH"),
                new KeyValuePair<int, string>(2, "DLR"),
                new KeyValuePair<int, string>(3, "EUR")
            };

            _viewModel = new MainFormViewModel(currencies)
            {
                Amount = 25,
                MinAmount = 10,
                MaxAmount = 100,
                TickFrequency = (100 - 10) / 15,
                MinAmountCaption = $"From {10} $",
                MaxAmountCaption = $"From {100} $",
                CurrencyCode = 3
            };
        }

        public void SetView(MainForm view)
        {
            Debug.Assert(_view == null);

            _view = view ?? throw new ArgumentNullException(nameof(view));

            _view.SetViewModel(_viewModel);
        }

        internal void HandleValueChangedOnAmountTrackBar(int value)
        {
            _viewModel.Amount = value;
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
    }
}
