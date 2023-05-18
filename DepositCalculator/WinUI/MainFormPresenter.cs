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
        private MainForm view;
        private readonly MainFormViewModel viewModel;

        public MainFormPresenter()
        {
            viewModel = new MainFormViewModel
            {
                Amount = 25,
                MinAmount = 10,
                MaxAmount = 100,
                MinAmountCaption = $"From {10} $",
                MaxAmountCaption = $"From {100} $"
            };
        }

        public void SetView(MainForm view)
        {
            Debug.Assert(this.view == null);

            this.view = view ?? throw new ArgumentNullException(nameof(view));

            this.view.SetViewModel(viewModel);
        }
    }
}
