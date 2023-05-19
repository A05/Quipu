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
                AmountTickFrequency = (100 - 10) / 15,
                MinAmountCaption = $"From {10} $",
                MaxAmountCaption = $"From {100} $",
                CurrencyCode = 3,
                Term = 12,
                MinTerm = 3,
                MaxTerm = 64,
                TermTickFrequency = (64 - 3) / 15,
                MinTermCaption = $"From {3} $",
                MaxTermCaption = $"From {64} $",
            };
        }

        public void SetView(MainForm view)
        {
            Debug.Assert(_view == null);

            _view = view ?? throw new ArgumentNullException(nameof(view));

            _view.SetViewModel(_viewModel);
        }

        public void HandleValueChangedOnAmountTrackBar(int value)
        {
            _viewModel.Amount = value;
        }

        public void HandleValueChangedOnTermTrackBar(int term)
        {
            _viewModel.Term = term;
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
    }
}
