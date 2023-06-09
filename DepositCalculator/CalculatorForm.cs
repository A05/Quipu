﻿using Sx.Vx.Quipu.Domain;
using Sx.Vx.Quipu.WinUI.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.WinUI
{
    internal partial class CalculatorForm : Form, ICalculatorForm
    {
        private readonly CalculatorFormPresenter _presenter;
        private readonly ComponentResourceManager _resourceManager;

        internal CalculatorForm(CalculatorFormPresenter presenter)
        {
            _presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));

            _resourceManager = new ComponentResourceManager(GetType());

            InitializeComponent();

            _presenter.SetView(this);            
        }

        public void SetViewModel(CalculatorFormViewModel viewModel)
        {
            bindingSource.DataSource = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        public void ApplyResources(CultureInfo culture)
        {
            Text = Resources.WindowTitle; // It is not applied with the "standard" way.

            ApplyResources(this, culture);
        }

        private void ApplyResources(Control parent, CultureInfo culture)
        {
            _resourceManager.ApplyResources(parent, parent.Name, culture);

            if (parent.GetType() == typeof(DataGridView))
                foreach (DataGridViewColumn col in ((DataGridView)parent).Columns)
                    _resourceManager.ApplyResources(col, col.Name, culture);

            foreach (Control child in parent.Controls)
                ApplyResources(child, culture);
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in interestPaymentDataGridView.Columns)
                if (col.Index == 1)
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            _presenter.HandleLoadOnView();
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

        private void currencyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;

            if (rb.Checked)
            {
                var model = (CalculatorFormViewModel)bindingSource.DataSource;

                if (sender == uahRadioButton)
                    model.Currency = Currency.UAH;
                else if (sender == usdRadioButton)
                    model.Currency = Currency.USD;
                else if (sender == eurRadioButton)
                    model.Currency = Currency.EUR;
                else
                    throw new NotSupportedException();
            }
        }

        private void interestPaymentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            InterestPayment interestPayment;

            if (sender == everyMonthRadioButton)
                interestPayment = InterestPayment.EveryMonth;
            else if (sender == everyQuarterRadioButton)
                interestPayment = InterestPayment.EveryQuarter;
            else if (sender == everyYearRadioButton)
                interestPayment = InterestPayment.EveryYear;
            else if (sender == endOfTermRadioButton)
                interestPayment = InterestPayment.AtTheEndOfTerm;
            else if (sender == c12nByDayRadioButton)
                interestPayment = InterestPayment.CapitalizationByDay;
            else if (sender == c12nByMonthRadioButton)
                interestPayment = InterestPayment.CapitalizationByMonth;
            else if (sender == c12nByQuarterRadioButton)
                interestPayment = InterestPayment.CapitalizationByQuarter;
            else if (sender == c12nByYearRadioButton)
                interestPayment = InterestPayment.CapitalizationByYear;
            else
                throw new NotSupportedException();

            var model = (CalculatorFormViewModel)bindingSource.DataSource;

            model.InterestPayment = interestPayment;
        }        

        private void langButton_Click(object sender, EventArgs e)
        {
            _presenter.HandleClickOnLanguageButton();
        }
    }
}
