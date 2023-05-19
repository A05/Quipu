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
                (1, "UAH"), (2, "DLR"), (3, "EUR")
            };

            _viewModel = new MainFormViewModel(currencies)
            {
                Amount = 25,
                MinAmount = 10,
                MaxAmount = 100,
                TickFrequency = (100 - 10) / 15,
                MinAmountCaption = $"From {10} $",
                MaxAmountCaption = $"From {100} $",
                
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
    }
}
