using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.WinUI
{
    public partial class CalculatorForm : Form
    {
        private readonly CalculatorFormPresenter _presenter;

        internal CalculatorForm(CalculatorFormPresenter presenter)
        {
            _presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
            
            InitializeComponent();

            _presenter.SetView(this);
        }

        internal void SetViewModel(CalculatorFormViewModel viewModel)
        {
            bindingSource.DataSource = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
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

        private void termTextBox_Validating(object sender, CancelEventArgs e)
        {
            Debug.Assert(sender == termTextBox);

            if (_presenter.IsTermValid(termTextBox.Text, out var error))
                errorProvider.SetError(termTextBox, string.Empty);
            else
            {
                e.Cancel = true;
                termTextBox.Select(0, termTextBox.Text.Length);
                errorProvider.SetError(termTextBox, error);
            }
        }

        private void interestRateTextBox_Validating(object sender, CancelEventArgs e)
        {
            Debug.Assert(sender == interestRateTextBox);

            if (_presenter.IsInterestRateValid(interestRateTextBox.Text, out var error))
                errorProvider.SetError(interestRateTextBox, string.Empty);
            else
            {
                e.Cancel = true;
                interestRateTextBox.Select(0, interestRateTextBox.Text.Length);
                errorProvider.SetError(interestRateTextBox, error);
            }
        }
    }
}
