namespace Sx.Vx.Quipu.DepositCalculator.WinUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.maxInterestRateLabel = new System.Windows.Forms.Label();
            this.minInterestRateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.interestRateTrackBar = new System.Windows.Forms.TrackBar();
            this.interestPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.maxTermLabel = new System.Windows.Forms.Label();
            this.minTermLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.termTrackBar = new System.Windows.Forms.TrackBar();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.maxAmountLabel = new System.Windows.Forms.Label();
            this.minAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTrackBar = new System.Windows.Forms.TrackBar();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incomeValueLabel = new System.Windows.Forms.Label();
            this.incomeCaptionLabel = new System.Windows.Forms.Label();
            this.interestPaymentValueLabel = new System.Windows.Forms.Label();
            this.interestPaymentCaptionLabel = new System.Windows.Forms.Label();
            this.interestRateValueLabel = new System.Windows.Forms.Label();
            this.interestRateCaptionLabel = new System.Windows.Forms.Label();
            this.termValueLabel = new System.Windows.Forms.Label();
            this.termCaptionLabel = new System.Windows.Forms.Label();
            this.amountValueLabel = new System.Windows.Forms.Label();
            this.amountCaptionLabel = new System.Windows.Forms.Label();
            this.interestPaymentDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTrackBar)).BeginInit();
            this.outputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestPaymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.label10);
            this.inputPanel.Controls.Add(this.maxInterestRateLabel);
            this.inputPanel.Controls.Add(this.minInterestRateLabel);
            this.inputPanel.Controls.Add(this.label9);
            this.inputPanel.Controls.Add(this.interestRateTrackBar);
            this.inputPanel.Controls.Add(this.interestPaymentComboBox);
            this.inputPanel.Controls.Add(this.interestRateTextBox);
            this.inputPanel.Controls.Add(this.maxTermLabel);
            this.inputPanel.Controls.Add(this.minTermLabel);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.termTrackBar);
            this.inputPanel.Controls.Add(this.termTextBox);
            this.inputPanel.Controls.Add(this.maxAmountLabel);
            this.inputPanel.Controls.Add(this.minAmountLabel);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.amountTrackBar);
            this.inputPanel.Controls.Add(this.currencyComboBox);
            this.inputPanel.Controls.Add(this.amountTextBox);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(278, 420);
            this.inputPanel.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Interest payment";
            // 
            // maxInterestRateLabel
            // 
            this.maxInterestRateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxInterestRateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxInterestRateCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxInterestRateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maxInterestRateLabel.Location = new System.Drawing.Point(163, 327);
            this.maxInterestRateLabel.Name = "maxInterestRateLabel";
            this.maxInterestRateLabel.Size = new System.Drawing.Size(100, 13);
            this.maxInterestRateLabel.TabIndex = 35;
            this.maxInterestRateLabel.Text = "Max";
            this.maxInterestRateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minInterestRateLabel
            // 
            this.minInterestRateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MinInterestRateCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.minInterestRateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minInterestRateLabel.Location = new System.Drawing.Point(10, 327);
            this.minInterestRateLabel.Name = "minInterestRateLabel";
            this.minInterestRateLabel.Size = new System.Drawing.Size(100, 13);
            this.minInterestRateLabel.TabIndex = 34;
            this.minInterestRateLabel.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Interest rate";
            // 
            // interestRateTrackBar
            // 
            this.interestRateTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestRateTrackBar.AutoSize = false;
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "InterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.bindingSource, "MaxInterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Minimum", this.bindingSource, "MinInterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("TickFrequency", this.bindingSource, "InterestRateTickFrequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateTrackBar.Location = new System.Drawing.Point(10, 294);
            this.interestRateTrackBar.Name = "interestRateTrackBar";
            this.interestRateTrackBar.Size = new System.Drawing.Size(253, 30);
            this.interestRateTrackBar.TabIndex = 32;
            // 
            // interestPaymentComboBox
            // 
            this.interestPaymentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestPaymentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "InterestPayment", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestPaymentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "InterestPaymentEntries", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.interestPaymentComboBox.DisplayMember = "Value";
            this.interestPaymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interestPaymentComboBox.FormattingEnabled = true;
            this.interestPaymentComboBox.Location = new System.Drawing.Point(10, 386);
            this.interestPaymentComboBox.Name = "interestPaymentComboBox";
            this.interestPaymentComboBox.Size = new System.Drawing.Size(253, 21);
            this.interestPaymentComboBox.TabIndex = 31;
            this.interestPaymentComboBox.ValueMember = "Key";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetIconPadding(this.interestRateTextBox, -20);
            this.interestRateTextBox.Location = new System.Drawing.Point(10, 268);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(253, 20);
            this.interestRateTextBox.TabIndex = 30;
            this.interestRateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.interestRateTextBox_Validating);
            // 
            // maxTermLabel
            // 
            this.maxTermLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxTermLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxTermCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxTermLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maxTermLabel.Location = new System.Drawing.Point(163, 209);
            this.maxTermLabel.Name = "maxTermLabel";
            this.maxTermLabel.Size = new System.Drawing.Size(100, 13);
            this.maxTermLabel.TabIndex = 29;
            this.maxTermLabel.Text = "Max";
            this.maxTermLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minTermLabel
            // 
            this.minTermLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MinTermCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.minTermLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minTermLabel.Location = new System.Drawing.Point(10, 209);
            this.minTermLabel.Name = "minTermLabel";
            this.minTermLabel.Size = new System.Drawing.Size(100, 13);
            this.minTermLabel.TabIndex = 28;
            this.minTermLabel.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Term";
            // 
            // termTrackBar
            // 
            this.termTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termTrackBar.AutoSize = false;
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "Term", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.bindingSource, "MaxTerm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Minimum", this.bindingSource, "MinTerm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("TickFrequency", this.bindingSource, "TermTickFrequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termTrackBar.Location = new System.Drawing.Point(10, 176);
            this.termTrackBar.Name = "termTrackBar";
            this.termTrackBar.Size = new System.Drawing.Size(253, 30);
            this.termTrackBar.TabIndex = 26;
            // 
            // termTextBox
            // 
            this.termTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Term", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetIconPadding(this.termTextBox, -20);
            this.termTextBox.Location = new System.Drawing.Point(10, 150);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(253, 20);
            this.termTextBox.TabIndex = 25;
            this.termTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.termTextBox_Validating);
            // 
            // maxAmountLabel
            // 
            this.maxAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxAmountCaption", true));
            this.maxAmountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maxAmountLabel.Location = new System.Drawing.Point(163, 91);
            this.maxAmountLabel.Name = "maxAmountLabel";
            this.maxAmountLabel.Size = new System.Drawing.Size(100, 13);
            this.maxAmountLabel.TabIndex = 24;
            this.maxAmountLabel.Text = "Max";
            this.maxAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minAmountLabel
            // 
            this.minAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MinAmountCaption", true));
            this.minAmountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minAmountLabel.Location = new System.Drawing.Point(10, 91);
            this.minAmountLabel.Name = "minAmountLabel";
            this.minAmountLabel.Size = new System.Drawing.Size(100, 13);
            this.minAmountLabel.TabIndex = 23;
            this.minAmountLabel.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Amount";
            // 
            // amountTrackBar
            // 
            this.amountTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTrackBar.AutoSize = false;
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.bindingSource, "MaxAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Minimum", this.bindingSource, "MinAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("TickFrequency", this.bindingSource, "AmountTickFrequency", true));
            this.amountTrackBar.Location = new System.Drawing.Point(10, 58);
            this.amountTrackBar.Name = "amountTrackBar";
            this.amountTrackBar.Size = new System.Drawing.Size(253, 30);
            this.amountTrackBar.TabIndex = 21;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "CurrencyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "CurrencyEntries", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.currencyComboBox.DisplayMember = "Value";
            this.currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(191, 31);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(72, 21);
            this.currencyComboBox.TabIndex = 20;
            this.currencyComboBox.ValueMember = "Key";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetIconPadding(this.amountTextBox, -20);
            this.amountTextBox.Location = new System.Drawing.Point(10, 32);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(175, 20);
            this.amountTextBox.TabIndex = 19;
            this.amountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.amountTextBox_Validating);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(273, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 420);
            this.splitter.TabIndex = 21;
            this.splitter.TabStop = false;
            // 
            // outputPanel
            // 
            this.outputPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputPanel.Controls.Add(this.panel1);
            this.outputPanel.Controls.Add(this.interestPaymentValueLabel);
            this.outputPanel.Controls.Add(this.interestPaymentCaptionLabel);
            this.outputPanel.Controls.Add(this.interestRateValueLabel);
            this.outputPanel.Controls.Add(this.interestRateCaptionLabel);
            this.outputPanel.Controls.Add(this.termValueLabel);
            this.outputPanel.Controls.Add(this.termCaptionLabel);
            this.outputPanel.Controls.Add(this.amountValueLabel);
            this.outputPanel.Controls.Add(this.amountCaptionLabel);
            this.outputPanel.Controls.Add(this.interestPaymentDataGridView);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.outputPanel.Location = new System.Drawing.Point(278, 0);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(269, 420);
            this.outputPanel.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.incomeValueLabel);
            this.panel1.Controls.Add(this.incomeCaptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 32);
            this.panel1.TabIndex = 35;
            // 
            // incomeValueLabel
            // 
            this.incomeValueLabel.AutoSize = true;
            this.incomeValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "IncomeDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.incomeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incomeValueLabel.Location = new System.Drawing.Point(121, 6);
            this.incomeValueLabel.Name = "incomeValueLabel";
            this.incomeValueLabel.Size = new System.Drawing.Size(80, 20);
            this.incomeValueLabel.TabIndex = 25;
            this.incomeValueLabel.Text = "20.000 $";
            // 
            // incomeCaptionLabel
            // 
            this.incomeCaptionLabel.AutoSize = true;
            this.incomeCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.incomeCaptionLabel.Location = new System.Drawing.Point(6, 6);
            this.incomeCaptionLabel.Name = "incomeCaptionLabel";
            this.incomeCaptionLabel.Size = new System.Drawing.Size(69, 20);
            this.incomeCaptionLabel.TabIndex = 24;
            this.incomeCaptionLabel.Text = "Income";
            // 
            // interestPaymentValueLabel
            // 
            this.interestPaymentValueLabel.AutoSize = true;
            this.interestPaymentValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InterestPaymentDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestPaymentValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestPaymentValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.interestPaymentValueLabel.Location = new System.Drawing.Point(122, 80);
            this.interestPaymentValueLabel.Name = "interestPaymentValueLabel";
            this.interestPaymentValueLabel.Size = new System.Drawing.Size(34, 17);
            this.interestPaymentValueLabel.TabIndex = 34;
            this.interestPaymentValueLabel.Text = "N/A";
            // 
            // interestPaymentCaptionLabel
            // 
            this.interestPaymentCaptionLabel.AutoSize = true;
            this.interestPaymentCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestPaymentCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.interestPaymentCaptionLabel.Location = new System.Drawing.Point(122, 58);
            this.interestPaymentCaptionLabel.Name = "interestPaymentCaptionLabel";
            this.interestPaymentCaptionLabel.Size = new System.Drawing.Size(129, 17);
            this.interestPaymentCaptionLabel.TabIndex = 33;
            this.interestPaymentCaptionLabel.Text = "Interest payment";
            // 
            // interestRateValueLabel
            // 
            this.interestRateValueLabel.AutoSize = true;
            this.interestRateValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InterestRateDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.interestRateValueLabel.Location = new System.Drawing.Point(6, 80);
            this.interestRateValueLabel.Name = "interestRateValueLabel";
            this.interestRateValueLabel.Size = new System.Drawing.Size(39, 17);
            this.interestRateValueLabel.TabIndex = 32;
            this.interestRateValueLabel.Text = "45%";
            // 
            // interestRateCaptionLabel
            // 
            this.interestRateCaptionLabel.AutoSize = true;
            this.interestRateCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.interestRateCaptionLabel.Location = new System.Drawing.Point(6, 58);
            this.interestRateCaptionLabel.Name = "interestRateCaptionLabel";
            this.interestRateCaptionLabel.Size = new System.Drawing.Size(97, 17);
            this.interestRateCaptionLabel.TabIndex = 31;
            this.interestRateCaptionLabel.Text = "Interest rate";
            // 
            // termValueLabel
            // 
            this.termValueLabel.AutoSize = true;
            this.termValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TermDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.termValueLabel.Location = new System.Drawing.Point(122, 31);
            this.termValueLabel.Name = "termValueLabel";
            this.termValueLabel.Size = new System.Drawing.Size(83, 17);
            this.termValueLabel.TabIndex = 30;
            this.termValueLabel.Text = "36 months";
            // 
            // termCaptionLabel
            // 
            this.termCaptionLabel.AutoSize = true;
            this.termCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.termCaptionLabel.Location = new System.Drawing.Point(122, 9);
            this.termCaptionLabel.Name = "termCaptionLabel";
            this.termCaptionLabel.Size = new System.Drawing.Size(45, 17);
            this.termCaptionLabel.TabIndex = 29;
            this.termCaptionLabel.Text = "Term";
            // 
            // amountValueLabel
            // 
            this.amountValueLabel.AutoSize = true;
            this.amountValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AmountDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.amountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amountValueLabel.Location = new System.Drawing.Point(6, 31);
            this.amountValueLabel.Name = "amountValueLabel";
            this.amountValueLabel.Size = new System.Drawing.Size(63, 17);
            this.amountValueLabel.TabIndex = 28;
            this.amountValueLabel.Text = "10.00 $";
            // 
            // amountCaptionLabel
            // 
            this.amountCaptionLabel.AutoSize = true;
            this.amountCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.amountCaptionLabel.Location = new System.Drawing.Point(6, 9);
            this.amountCaptionLabel.Name = "amountCaptionLabel";
            this.amountCaptionLabel.Size = new System.Drawing.Size(62, 17);
            this.amountCaptionLabel.TabIndex = 27;
            this.amountCaptionLabel.Text = "Amount";
            // 
            // interestPaymentDataGridView
            // 
            this.interestPaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.interestPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interestPaymentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.interestPaymentDataGridView.Location = new System.Drawing.Point(0, 141);
            this.interestPaymentDataGridView.Name = "interestPaymentDataGridView";
            this.interestPaymentDataGridView.Size = new System.Drawing.Size(269, 279);
            this.interestPaymentDataGridView.TabIndex = 26;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = typeof(Sx.Vx.Quipu.DepositCalculator.WinUI.MainFormViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 420);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.outputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Deposit Calculator";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTrackBar)).EndInit();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestPaymentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label maxInterestRateLabel;
        private System.Windows.Forms.Label minInterestRateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar interestRateTrackBar;
        private System.Windows.Forms.ComboBox interestPaymentComboBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Label maxTermLabel;
        private System.Windows.Forms.Label minTermLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar termTrackBar;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.Label maxAmountLabel;
        private System.Windows.Forms.Label minAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar amountTrackBar;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Label incomeCaptionLabel;
        private System.Windows.Forms.Label incomeValueLabel;
        private System.Windows.Forms.DataGridView interestPaymentDataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label amountValueLabel;
        private System.Windows.Forms.Label amountCaptionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label interestPaymentValueLabel;
        private System.Windows.Forms.Label interestPaymentCaptionLabel;
        private System.Windows.Forms.Label interestRateValueLabel;
        private System.Windows.Forms.Label interestRateCaptionLabel;
        private System.Windows.Forms.Label termValueLabel;
        private System.Windows.Forms.Label termCaptionLabel;
    }
}

