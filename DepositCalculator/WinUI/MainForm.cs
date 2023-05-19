using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    public partial class MainForm : Form
    {
        private readonly MainFormPresenter _presenter;

        internal MainForm(MainFormPresenter presenter)
        {
            _presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
            
            InitializeComponent();

            _presenter.SetView(this);
        }

        internal void SetViewModel(MainFormViewModel viewModel)
        {
            bindingSource.DataSource = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        private void amountTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Debug.Assert(sender == amountTrackBar);

            _presenter.HandleValueChangedOnAmountTrackBar(amountTrackBar.Value);
        }

        private void amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            Debug.Assert(sender == amountTextBox);

            if (_presenter.IsAmountValid(amountTextBox.Text, out var error))
                errorProvider.SetError(amountTextBox, string.Empty);
            else
            {
                e.Cancel = true;
                amountTextBox.Select(0, amountTextBox.Text.Length);
                errorProvider.SetError(amountTextBox, error);
            }
        }
    }
}
