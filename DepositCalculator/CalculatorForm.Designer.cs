namespace Sx.Vx.Quipu.WinUI
{
    partial class CalculatorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.c12nByYearRadioButton = new System.Windows.Forms.RadioButton();
            this.c12nByQuarterRadioButton = new System.Windows.Forms.RadioButton();
            this.c12nByMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.c12nByDayRadioButton = new System.Windows.Forms.RadioButton();
            this.endOfTermRadioButton = new System.Windows.Forms.RadioButton();
            this.everyYearRadioButton = new System.Windows.Forms.RadioButton();
            this.everyQuarterRadioButton = new System.Windows.Forms.RadioButton();
            this.everyMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.maxInterestRateLabel = new System.Windows.Forms.Label();
            this.minInterestRateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.interestRateTrackBar = new System.Windows.Forms.TrackBar();
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
            this.incomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.currencyPanel = new System.Windows.Forms.Panel();
            this.uahRadioButton = new System.Windows.Forms.RadioButton();
            this.usdRadioButton = new System.Windows.Forms.RadioButton();
            this.eurRadioButton = new System.Windows.Forms.RadioButton();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTrackBar)).BeginInit();
            this.outputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestPaymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.currencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.currencyPanel);
            this.inputPanel.Controls.Add(this.c12nByYearRadioButton);
            this.inputPanel.Controls.Add(this.c12nByQuarterRadioButton);
            this.inputPanel.Controls.Add(this.currencyComboBox);
            this.inputPanel.Controls.Add(this.c12nByMonthRadioButton);
            this.inputPanel.Controls.Add(this.c12nByDayRadioButton);
            this.inputPanel.Controls.Add(this.endOfTermRadioButton);
            this.inputPanel.Controls.Add(this.everyYearRadioButton);
            this.inputPanel.Controls.Add(this.everyQuarterRadioButton);
            this.inputPanel.Controls.Add(this.everyMonthRadioButton);
            this.inputPanel.Controls.Add(this.label10);
            this.inputPanel.Controls.Add(this.maxInterestRateLabel);
            this.inputPanel.Controls.Add(this.minInterestRateLabel);
            this.inputPanel.Controls.Add(this.label9);
            this.inputPanel.Controls.Add(this.interestRateTrackBar);
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
            this.inputPanel.Controls.Add(this.amountTextBox);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(279, 489);
            this.inputPanel.TabIndex = 20;
            // 
            // c12nByYearRadioButton
            // 
            this.c12nByYearRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c12nByYearRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.c12nByYearRadioButton.Location = new System.Drawing.Point(124, 455);
            this.c12nByYearRadioButton.Name = "c12nByYearRadioButton";
            this.c12nByYearRadioButton.Size = new System.Drawing.Size(144, 24);
            this.c12nByYearRadioButton.TabIndex = 45;
            this.c12nByYearRadioButton.Text = "Capitalization By Year";
            this.c12nByYearRadioButton.UseVisualStyleBackColor = true;
            this.c12nByYearRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // c12nByQuarterRadioButton
            // 
            this.c12nByQuarterRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c12nByQuarterRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.c12nByQuarterRadioButton.Location = new System.Drawing.Point(124, 425);
            this.c12nByQuarterRadioButton.Name = "c12nByQuarterRadioButton";
            this.c12nByQuarterRadioButton.Size = new System.Drawing.Size(144, 24);
            this.c12nByQuarterRadioButton.TabIndex = 44;
            this.c12nByQuarterRadioButton.Text = "Capitalization By Quarter";
            this.c12nByQuarterRadioButton.UseVisualStyleBackColor = true;
            this.c12nByQuarterRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // c12nByMonthRadioButton
            // 
            this.c12nByMonthRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c12nByMonthRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.c12nByMonthRadioButton.Location = new System.Drawing.Point(124, 395);
            this.c12nByMonthRadioButton.Name = "c12nByMonthRadioButton";
            this.c12nByMonthRadioButton.Size = new System.Drawing.Size(144, 24);
            this.c12nByMonthRadioButton.TabIndex = 43;
            this.c12nByMonthRadioButton.Text = "Capitalization By Month";
            this.c12nByMonthRadioButton.UseVisualStyleBackColor = true;
            this.c12nByMonthRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // c12nByDayRadioButton
            // 
            this.c12nByDayRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c12nByDayRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.c12nByDayRadioButton.Location = new System.Drawing.Point(124, 365);
            this.c12nByDayRadioButton.Name = "c12nByDayRadioButton";
            this.c12nByDayRadioButton.Size = new System.Drawing.Size(144, 24);
            this.c12nByDayRadioButton.TabIndex = 42;
            this.c12nByDayRadioButton.Text = "Capitalization By Day";
            this.c12nByDayRadioButton.UseVisualStyleBackColor = true;
            this.c12nByDayRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // endOfTermRadioButton
            // 
            this.endOfTermRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.endOfTermRadioButton.Location = new System.Drawing.Point(10, 455);
            this.endOfTermRadioButton.Name = "endOfTermRadioButton";
            this.endOfTermRadioButton.Size = new System.Drawing.Size(108, 24);
            this.endOfTermRadioButton.TabIndex = 41;
            this.endOfTermRadioButton.Text = "End of term";
            this.endOfTermRadioButton.UseVisualStyleBackColor = true;
            this.endOfTermRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // everyYearRadioButton
            // 
            this.everyYearRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.everyYearRadioButton.Location = new System.Drawing.Point(10, 425);
            this.everyYearRadioButton.Name = "everyYearRadioButton";
            this.everyYearRadioButton.Size = new System.Drawing.Size(108, 24);
            this.everyYearRadioButton.TabIndex = 40;
            this.everyYearRadioButton.Text = "Every year";
            this.everyYearRadioButton.UseVisualStyleBackColor = true;
            this.everyYearRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // everyQuarterRadioButton
            // 
            this.everyQuarterRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.everyQuarterRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsEveryQuarterRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.everyQuarterRadioButton.Location = new System.Drawing.Point(10, 395);
            this.everyQuarterRadioButton.Name = "everyQuarterRadioButton";
            this.everyQuarterRadioButton.Size = new System.Drawing.Size(108, 24);
            this.everyQuarterRadioButton.TabIndex = 39;
            this.everyQuarterRadioButton.Text = "Every quarter";
            this.everyQuarterRadioButton.UseVisualStyleBackColor = true;
            this.everyQuarterRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // everyMonthRadioButton
            // 
            this.everyMonthRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.everyMonthRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsEveryMonthRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.everyMonthRadioButton.Location = new System.Drawing.Point(10, 365);
            this.everyMonthRadioButton.Name = "everyMonthRadioButton";
            this.everyMonthRadioButton.Size = new System.Drawing.Size(108, 24);
            this.everyMonthRadioButton.TabIndex = 38;
            this.everyMonthRadioButton.Text = "Every month";
            this.everyMonthRadioButton.UseVisualStyleBackColor = true;
            this.everyMonthRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 344);
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
            this.maxInterestRateLabel.Location = new System.Drawing.Point(164, 323);
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
            this.minInterestRateLabel.Location = new System.Drawing.Point(10, 323);
            this.minInterestRateLabel.Name = "minInterestRateLabel";
            this.minInterestRateLabel.Size = new System.Drawing.Size(100, 13);
            this.minInterestRateLabel.TabIndex = 34;
            this.minInterestRateLabel.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 242);
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
            this.interestRateTrackBar.Location = new System.Drawing.Point(10, 290);
            this.interestRateTrackBar.Name = "interestRateTrackBar";
            this.interestRateTrackBar.Size = new System.Drawing.Size(254, 30);
            this.interestRateTrackBar.TabIndex = 32;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetIconPadding(this.interestRateTextBox, -20);
            this.interestRateTextBox.Location = new System.Drawing.Point(10, 264);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(254, 20);
            this.interestRateTextBox.TabIndex = 30;
            this.interestRateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.interestRateTextBox_Validating);
            // 
            // maxTermLabel
            // 
            this.maxTermLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxTermLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxTermCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxTermLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maxTermLabel.Location = new System.Drawing.Point(164, 221);
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
            this.minTermLabel.Location = new System.Drawing.Point(10, 221);
            this.minTermLabel.Name = "minTermLabel";
            this.minTermLabel.Size = new System.Drawing.Size(100, 13);
            this.minTermLabel.TabIndex = 28;
            this.minTermLabel.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 140);
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
            this.termTrackBar.Location = new System.Drawing.Point(10, 188);
            this.termTrackBar.Name = "termTrackBar";
            this.termTrackBar.Size = new System.Drawing.Size(254, 30);
            this.termTrackBar.TabIndex = 26;
            // 
            // termTextBox
            // 
            this.termTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Term", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetIconPadding(this.termTextBox, -20);
            this.termTextBox.Location = new System.Drawing.Point(10, 162);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(254, 20);
            this.termTextBox.TabIndex = 25;
            this.termTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.termTextBox_Validating);
            // 
            // maxAmountLabel
            // 
            this.maxAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxAmountCaption", true));
            this.maxAmountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.maxAmountLabel.Location = new System.Drawing.Point(164, 120);
            this.maxAmountLabel.Name = "maxAmountLabel";
            this.maxAmountLabel.Size = new System.Drawing.Size(100, 13);
            this.maxAmountLabel.TabIndex = 24;
            this.maxAmountLabel.Text = "Max";
            this.maxAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.maxAmountLabel.Click += new System.EventHandler(this.maxAmountLabel_Click);
            // 
            // minAmountLabel
            // 
            this.minAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MinAmountCaption", true));
            this.minAmountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minAmountLabel.Location = new System.Drawing.Point(10, 120);
            this.minAmountLabel.Name = "minAmountLabel";
            this.minAmountLabel.Size = new System.Drawing.Size(100, 13);
            this.minAmountLabel.TabIndex = 23;
            this.minAmountLabel.Text = "Min";
            this.minAmountLabel.Click += new System.EventHandler(this.minAmountLabel_Click);
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
            this.amountTrackBar.Location = new System.Drawing.Point(10, 87);
            this.amountTrackBar.Name = "amountTrackBar";
            this.amountTrackBar.Size = new System.Drawing.Size(254, 30);
            this.amountTrackBar.TabIndex = 21;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "ComboBoxCurrencyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "CurrencyEntries", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.currencyComboBox.DisplayMember = "Value";
            this.currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyComboBox.DropDownWidth = 275;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(10, 60);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(254, 21);
            this.currencyComboBox.TabIndex = 20;
            this.currencyComboBox.ValueMember = "Key";
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetIconPadding(this.amountTextBox, -20);
            this.amountTextBox.Location = new System.Drawing.Point(10, 32);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(162, 20);
            this.amountTextBox.TabIndex = 19;
            this.amountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.amountTextBox_Validating);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(274, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 489);
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
            this.outputPanel.Location = new System.Drawing.Point(279, 0);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(269, 489);
            this.outputPanel.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.incomeValueLabel);
            this.panel1.Controls.Add(this.incomeCaptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 108);
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
            this.incomeValueLabel.Location = new System.Drawing.Point(125, 6);
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
            this.interestPaymentValueLabel.Location = new System.Drawing.Point(125, 80);
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
            this.interestPaymentCaptionLabel.Location = new System.Drawing.Point(125, 58);
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
            this.termValueLabel.Location = new System.Drawing.Point(125, 31);
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
            this.termCaptionLabel.Location = new System.Drawing.Point(125, 9);
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
            this.interestPaymentDataGridView.AutoGenerateColumns = false;
            this.interestPaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.interestPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interestPaymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.interestPaymentDataGridView.DataSource = this.incomesBindingSource;
            this.interestPaymentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.interestPaymentDataGridView.Location = new System.Drawing.Point(0, 140);
            this.interestPaymentDataGridView.Name = "interestPaymentDataGridView";
            this.interestPaymentDataGridView.Size = new System.Drawing.Size(269, 349);
            this.interestPaymentDataGridView.TabIndex = 26;
            // 
            // incomesBindingSource
            // 
            this.incomesBindingSource.DataMember = "Incomes";
            this.incomesBindingSource.DataSource = this.bindingSource;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // currencyPanel
            // 
            this.currencyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyPanel.Controls.Add(this.eurRadioButton);
            this.currencyPanel.Controls.Add(this.usdRadioButton);
            this.currencyPanel.Controls.Add(this.uahRadioButton);
            this.currencyPanel.Location = new System.Drawing.Point(178, 25);
            this.currencyPanel.Name = "currencyPanel";
            this.currencyPanel.Size = new System.Drawing.Size(86, 31);
            this.currencyPanel.TabIndex = 46;
            // 
            // uahRadioButton
            // 
            this.uahRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.uahRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsUahRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.uahRadioButton.Location = new System.Drawing.Point(0, 5);
            this.uahRadioButton.Name = "uahRadioButton";
            this.uahRadioButton.Size = new System.Drawing.Size(26, 22);
            this.uahRadioButton.TabIndex = 21;
            this.uahRadioButton.TabStop = true;
            this.uahRadioButton.Text = "₴";
            this.uahRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uahRadioButton.UseVisualStyleBackColor = true;
            this.uahRadioButton.CheckedChanged += new System.EventHandler(this.currencyRadioButton_CheckedChanged);
            // 
            // usdRadioButton
            // 
            this.usdRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.usdRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsUsdRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usdRadioButton.Location = new System.Drawing.Point(30, 5);
            this.usdRadioButton.Name = "usdRadioButton";
            this.usdRadioButton.Size = new System.Drawing.Size(26, 22);
            this.usdRadioButton.TabIndex = 22;
            this.usdRadioButton.TabStop = true;
            this.usdRadioButton.Text = "$";
            this.usdRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usdRadioButton.UseVisualStyleBackColor = true;
            this.usdRadioButton.CheckedChanged += new System.EventHandler(this.currencyRadioButton_CheckedChanged);
            // 
            // eurRadioButton
            // 
            this.eurRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.eurRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsEurRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.eurRadioButton.Location = new System.Drawing.Point(60, 5);
            this.eurRadioButton.Name = "eurRadioButton";
            this.eurRadioButton.Size = new System.Drawing.Size(26, 22);
            this.eurRadioButton.TabIndex = 23;
            this.eurRadioButton.TabStop = true;
            this.eurRadioButton.Text = "€";
            this.eurRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eurRadioButton.UseVisualStyleBackColor = true;
            this.eurRadioButton.CheckedChanged += new System.EventHandler(this.currencyRadioButton_CheckedChanged);
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = typeof(Sx.Vx.Quipu.WinUI.CalculatorFormViewModel);
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.keyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.keyDataGridViewTextBoxColumn.HeaderText = "Date";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Income";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 489);
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.outputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Deposit Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.currencyPanel.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource incomesBindingSource;
        private System.Windows.Forms.RadioButton everyMonthRadioButton;
        private System.Windows.Forms.RadioButton everyQuarterRadioButton;
        private System.Windows.Forms.RadioButton c12nByYearRadioButton;
        private System.Windows.Forms.RadioButton c12nByQuarterRadioButton;
        private System.Windows.Forms.RadioButton c12nByMonthRadioButton;
        private System.Windows.Forms.RadioButton c12nByDayRadioButton;
        private System.Windows.Forms.RadioButton endOfTermRadioButton;
        private System.Windows.Forms.RadioButton everyYearRadioButton;
        private System.Windows.Forms.Panel currencyPanel;
        private System.Windows.Forms.RadioButton eurRadioButton;
        private System.Windows.Forms.RadioButton usdRadioButton;
        private System.Windows.Forms.RadioButton uahRadioButton;
    }
}

