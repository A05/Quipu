﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    public partial class MainForm : Form
    {
        private readonly MainFormPresenter presenter;

        internal MainForm(MainFormPresenter presenter)
        {
            this.presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
            
            InitializeComponent();

            this.presenter.SetView(this);
        }

        internal void SetViewModel(MainFormViewModel viewModel)
        {
            bindingSource.DataSource = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }
    }
}
