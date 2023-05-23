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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.currencyPanel = new System.Windows.Forms.Panel();
            this.eurRadioButton = new System.Windows.Forms.RadioButton();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usdRadioButton = new System.Windows.Forms.RadioButton();
            this.uahRadioButton = new System.Windows.Forms.RadioButton();
            this.c12nByYearRadioButton = new System.Windows.Forms.RadioButton();
            this.c12nByQuarterRadioButton = new System.Windows.Forms.RadioButton();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
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
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.langButton = new System.Windows.Forms.Button();
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
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.inputPanel.SuspendLayout();
            this.currencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTrackBar)).BeginInit();
            this.outputPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestPaymentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            resources.ApplyResources(this.inputPanel, "inputPanel");
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
            this.errorProvider.SetError(this.inputPanel, resources.GetString("inputPanel.Error"));
            this.errorProvider.SetIconAlignment(this.inputPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("inputPanel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.inputPanel, ((int)(resources.GetObject("inputPanel.IconPadding"))));
            this.inputPanel.Name = "inputPanel";
            // 
            // currencyPanel
            // 
            resources.ApplyResources(this.currencyPanel, "currencyPanel");
            this.currencyPanel.Controls.Add(this.eurRadioButton);
            this.currencyPanel.Controls.Add(this.usdRadioButton);
            this.currencyPanel.Controls.Add(this.uahRadioButton);
            this.errorProvider.SetError(this.currencyPanel, resources.GetString("currencyPanel.Error"));
            this.errorProvider.SetIconAlignment(this.currencyPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("currencyPanel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.currencyPanel, ((int)(resources.GetObject("currencyPanel.IconPadding"))));
            this.currencyPanel.Name = "currencyPanel";
            // 
            // eurRadioButton
            // 
            resources.ApplyResources(this.eurRadioButton, "eurRadioButton");
            this.eurRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsEurRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.eurRadioButton, resources.GetString("eurRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.eurRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("eurRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.eurRadioButton, ((int)(resources.GetObject("eurRadioButton.IconPadding"))));
            this.eurRadioButton.Name = "eurRadioButton";
            this.eurRadioButton.TabStop = true;
            this.eurRadioButton.UseVisualStyleBackColor = true;
            this.eurRadioButton.CheckedChanged += new System.EventHandler(this.currencyRadioButton_CheckedChanged);
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = typeof(Sx.Vx.Quipu.WinUI.CalculatorFormViewModel);
            // 
            // usdRadioButton
            // 
            resources.ApplyResources(this.usdRadioButton, "usdRadioButton");
            this.usdRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsUsdRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.usdRadioButton, resources.GetString("usdRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.usdRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("usdRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.usdRadioButton, ((int)(resources.GetObject("usdRadioButton.IconPadding"))));
            this.usdRadioButton.Name = "usdRadioButton";
            this.usdRadioButton.TabStop = true;
            this.usdRadioButton.UseVisualStyleBackColor = true;
            this.usdRadioButton.CheckedChanged += new System.EventHandler(this.currencyRadioButton_CheckedChanged);
            // 
            // uahRadioButton
            // 
            resources.ApplyResources(this.uahRadioButton, "uahRadioButton");
            this.uahRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsUahRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.uahRadioButton, resources.GetString("uahRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.uahRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("uahRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.uahRadioButton, ((int)(resources.GetObject("uahRadioButton.IconPadding"))));
            this.uahRadioButton.Name = "uahRadioButton";
            this.uahRadioButton.TabStop = true;
            this.uahRadioButton.UseVisualStyleBackColor = true;
            this.uahRadioButton.CheckedChanged += new System.EventHandler(this.currencyRadioButton_CheckedChanged);
            // 
            // c12nByYearRadioButton
            // 
            resources.ApplyResources(this.c12nByYearRadioButton, "c12nByYearRadioButton");
            this.errorProvider.SetError(this.c12nByYearRadioButton, resources.GetString("c12nByYearRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.c12nByYearRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("c12nByYearRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.c12nByYearRadioButton, ((int)(resources.GetObject("c12nByYearRadioButton.IconPadding"))));
            this.c12nByYearRadioButton.Name = "c12nByYearRadioButton";
            this.c12nByYearRadioButton.UseVisualStyleBackColor = true;
            this.c12nByYearRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // c12nByQuarterRadioButton
            // 
            resources.ApplyResources(this.c12nByQuarterRadioButton, "c12nByQuarterRadioButton");
            this.errorProvider.SetError(this.c12nByQuarterRadioButton, resources.GetString("c12nByQuarterRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.c12nByQuarterRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("c12nByQuarterRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.c12nByQuarterRadioButton, ((int)(resources.GetObject("c12nByQuarterRadioButton.IconPadding"))));
            this.c12nByQuarterRadioButton.Name = "c12nByQuarterRadioButton";
            this.c12nByQuarterRadioButton.UseVisualStyleBackColor = true;
            this.c12nByQuarterRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // currencyComboBox
            // 
            resources.ApplyResources(this.currencyComboBox, "currencyComboBox");
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "ComboBoxCurrency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.currencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.bindingSource, "CurrencyEntries", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.currencyComboBox.DisplayMember = "Value";
            this.currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorProvider.SetError(this.currencyComboBox, resources.GetString("currencyComboBox.Error"));
            this.currencyComboBox.FormattingEnabled = true;
            this.errorProvider.SetIconAlignment(this.currencyComboBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("currencyComboBox.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.currencyComboBox, ((int)(resources.GetObject("currencyComboBox.IconPadding"))));
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.ValueMember = "Key";
            // 
            // c12nByMonthRadioButton
            // 
            resources.ApplyResources(this.c12nByMonthRadioButton, "c12nByMonthRadioButton");
            this.errorProvider.SetError(this.c12nByMonthRadioButton, resources.GetString("c12nByMonthRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.c12nByMonthRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("c12nByMonthRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.c12nByMonthRadioButton, ((int)(resources.GetObject("c12nByMonthRadioButton.IconPadding"))));
            this.c12nByMonthRadioButton.Name = "c12nByMonthRadioButton";
            this.c12nByMonthRadioButton.UseVisualStyleBackColor = true;
            this.c12nByMonthRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // c12nByDayRadioButton
            // 
            resources.ApplyResources(this.c12nByDayRadioButton, "c12nByDayRadioButton");
            this.errorProvider.SetError(this.c12nByDayRadioButton, resources.GetString("c12nByDayRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.c12nByDayRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("c12nByDayRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.c12nByDayRadioButton, ((int)(resources.GetObject("c12nByDayRadioButton.IconPadding"))));
            this.c12nByDayRadioButton.Name = "c12nByDayRadioButton";
            this.c12nByDayRadioButton.UseVisualStyleBackColor = true;
            this.c12nByDayRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // endOfTermRadioButton
            // 
            resources.ApplyResources(this.endOfTermRadioButton, "endOfTermRadioButton");
            this.errorProvider.SetError(this.endOfTermRadioButton, resources.GetString("endOfTermRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.endOfTermRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("endOfTermRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.endOfTermRadioButton, ((int)(resources.GetObject("endOfTermRadioButton.IconPadding"))));
            this.endOfTermRadioButton.Name = "endOfTermRadioButton";
            this.endOfTermRadioButton.UseVisualStyleBackColor = true;
            this.endOfTermRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // everyYearRadioButton
            // 
            resources.ApplyResources(this.everyYearRadioButton, "everyYearRadioButton");
            this.errorProvider.SetError(this.everyYearRadioButton, resources.GetString("everyYearRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.everyYearRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("everyYearRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.everyYearRadioButton, ((int)(resources.GetObject("everyYearRadioButton.IconPadding"))));
            this.everyYearRadioButton.Name = "everyYearRadioButton";
            this.everyYearRadioButton.UseVisualStyleBackColor = true;
            this.everyYearRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // everyQuarterRadioButton
            // 
            resources.ApplyResources(this.everyQuarterRadioButton, "everyQuarterRadioButton");
            this.everyQuarterRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsEveryQuarterRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.everyQuarterRadioButton, resources.GetString("everyQuarterRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.everyQuarterRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("everyQuarterRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.everyQuarterRadioButton, ((int)(resources.GetObject("everyQuarterRadioButton.IconPadding"))));
            this.everyQuarterRadioButton.Name = "everyQuarterRadioButton";
            this.everyQuarterRadioButton.UseVisualStyleBackColor = true;
            this.everyQuarterRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // everyMonthRadioButton
            // 
            resources.ApplyResources(this.everyMonthRadioButton, "everyMonthRadioButton");
            this.everyMonthRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "IsEveryMonthRadioButtonChecked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.everyMonthRadioButton, resources.GetString("everyMonthRadioButton.Error"));
            this.errorProvider.SetIconAlignment(this.everyMonthRadioButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("everyMonthRadioButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.everyMonthRadioButton, ((int)(resources.GetObject("everyMonthRadioButton.IconPadding"))));
            this.everyMonthRadioButton.Name = "everyMonthRadioButton";
            this.everyMonthRadioButton.UseVisualStyleBackColor = true;
            this.everyMonthRadioButton.CheckedChanged += new System.EventHandler(this.interestPaymentRadioButton_CheckedChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.errorProvider.SetError(this.label10, resources.GetString("label10.Error"));
            this.errorProvider.SetIconAlignment(this.label10, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label10.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.label10, ((int)(resources.GetObject("label10.IconPadding"))));
            this.label10.Name = "label10";
            // 
            // maxInterestRateLabel
            // 
            resources.ApplyResources(this.maxInterestRateLabel, "maxInterestRateLabel");
            this.maxInterestRateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxInterestRateCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.maxInterestRateLabel, resources.GetString("maxInterestRateLabel.Error"));
            this.maxInterestRateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.maxInterestRateLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("maxInterestRateLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.maxInterestRateLabel, ((int)(resources.GetObject("maxInterestRateLabel.IconPadding"))));
            this.maxInterestRateLabel.Name = "maxInterestRateLabel";
            // 
            // minInterestRateLabel
            // 
            resources.ApplyResources(this.minInterestRateLabel, "minInterestRateLabel");
            this.minInterestRateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MinInterestRateCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.minInterestRateLabel, resources.GetString("minInterestRateLabel.Error"));
            this.minInterestRateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.minInterestRateLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("minInterestRateLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.minInterestRateLabel, ((int)(resources.GetObject("minInterestRateLabel.IconPadding"))));
            this.minInterestRateLabel.Name = "minInterestRateLabel";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.errorProvider.SetError(this.label9, resources.GetString("label9.Error"));
            this.errorProvider.SetIconAlignment(this.label9, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label9.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.label9, ((int)(resources.GetObject("label9.IconPadding"))));
            this.label9.Name = "label9";
            // 
            // interestRateTrackBar
            // 
            resources.ApplyResources(this.interestRateTrackBar, "interestRateTrackBar");
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "InterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.bindingSource, "MaxInterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Minimum", this.bindingSource, "MinInterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.interestRateTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("TickFrequency", this.bindingSource, "InterestRateTickFrequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.interestRateTrackBar, resources.GetString("interestRateTrackBar.Error"));
            this.errorProvider.SetIconAlignment(this.interestRateTrackBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("interestRateTrackBar.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.interestRateTrackBar, ((int)(resources.GetObject("interestRateTrackBar.IconPadding"))));
            this.interestRateTrackBar.Name = "interestRateTrackBar";
            // 
            // interestRateTextBox
            // 
            resources.ApplyResources(this.interestRateTextBox, "interestRateTextBox");
            this.interestRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InterestRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.interestRateTextBox, resources.GetString("interestRateTextBox.Error"));
            this.errorProvider.SetIconAlignment(this.interestRateTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("interestRateTextBox.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.interestRateTextBox, ((int)(resources.GetObject("interestRateTextBox.IconPadding"))));
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.interestRateTextBox_Validating);
            // 
            // maxTermLabel
            // 
            resources.ApplyResources(this.maxTermLabel, "maxTermLabel");
            this.maxTermLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxTermCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.maxTermLabel, resources.GetString("maxTermLabel.Error"));
            this.maxTermLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.maxTermLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("maxTermLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.maxTermLabel, ((int)(resources.GetObject("maxTermLabel.IconPadding"))));
            this.maxTermLabel.Name = "maxTermLabel";
            // 
            // minTermLabel
            // 
            resources.ApplyResources(this.minTermLabel, "minTermLabel");
            this.minTermLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MinTermCaption", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.minTermLabel, resources.GetString("minTermLabel.Error"));
            this.minTermLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.minTermLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("minTermLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.minTermLabel, ((int)(resources.GetObject("minTermLabel.IconPadding"))));
            this.minTermLabel.Name = "minTermLabel";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.errorProvider.SetError(this.label6, resources.GetString("label6.Error"));
            this.errorProvider.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // termTrackBar
            // 
            resources.ApplyResources(this.termTrackBar, "termTrackBar");
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "Term", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.bindingSource, "MaxTerm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Minimum", this.bindingSource, "MinTerm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.termTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("TickFrequency", this.bindingSource, "TermTickFrequency", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.termTrackBar, resources.GetString("termTrackBar.Error"));
            this.errorProvider.SetIconAlignment(this.termTrackBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("termTrackBar.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.termTrackBar, ((int)(resources.GetObject("termTrackBar.IconPadding"))));
            this.termTrackBar.Name = "termTrackBar";
            // 
            // termTextBox
            // 
            resources.ApplyResources(this.termTextBox, "termTextBox");
            this.termTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Term", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.termTextBox, resources.GetString("termTextBox.Error"));
            this.errorProvider.SetIconAlignment(this.termTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("termTextBox.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.termTextBox, ((int)(resources.GetObject("termTextBox.IconPadding"))));
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.termTextBox_Validating);
            // 
            // maxAmountLabel
            // 
            resources.ApplyResources(this.maxAmountLabel, "maxAmountLabel");
            this.maxAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MaxAmountCaption", true));
            this.errorProvider.SetError(this.maxAmountLabel, resources.GetString("maxAmountLabel.Error"));
            this.maxAmountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.maxAmountLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("maxAmountLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.maxAmountLabel, ((int)(resources.GetObject("maxAmountLabel.IconPadding"))));
            this.maxAmountLabel.Name = "maxAmountLabel";
            // 
            // minAmountLabel
            // 
            resources.ApplyResources(this.minAmountLabel, "minAmountLabel");
            this.minAmountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "MinAmountCaption", true));
            this.errorProvider.SetError(this.minAmountLabel, resources.GetString("minAmountLabel.Error"));
            this.minAmountLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.minAmountLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("minAmountLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.minAmountLabel, ((int)(resources.GetObject("minAmountLabel.IconPadding"))));
            this.minAmountLabel.Name = "minAmountLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // amountTrackBar
            // 
            resources.ApplyResources(this.amountTrackBar, "amountTrackBar");
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Maximum", this.bindingSource, "MaxAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Minimum", this.bindingSource, "MinAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.amountTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("TickFrequency", this.bindingSource, "AmountTickFrequency", true));
            this.errorProvider.SetError(this.amountTrackBar, resources.GetString("amountTrackBar.Error"));
            this.errorProvider.SetIconAlignment(this.amountTrackBar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("amountTrackBar.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.amountTrackBar, ((int)(resources.GetObject("amountTrackBar.IconPadding"))));
            this.amountTrackBar.Name = "amountTrackBar";
            // 
            // amountTextBox
            // 
            resources.ApplyResources(this.amountTextBox, "amountTextBox");
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.amountTextBox, resources.GetString("amountTextBox.Error"));
            this.errorProvider.SetIconAlignment(this.amountTextBox, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("amountTextBox.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.amountTextBox, ((int)(resources.GetObject("amountTextBox.IconPadding"))));
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.amountTextBox_Validating);
            // 
            // splitter
            // 
            resources.ApplyResources(this.splitter, "splitter");
            this.errorProvider.SetError(this.splitter, resources.GetString("splitter.Error"));
            this.errorProvider.SetIconAlignment(this.splitter, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("splitter.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.splitter, ((int)(resources.GetObject("splitter.IconPadding"))));
            this.splitter.Name = "splitter";
            this.splitter.TabStop = false;
            // 
            // outputPanel
            // 
            resources.ApplyResources(this.outputPanel, "outputPanel");
            this.outputPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputPanel.Controls.Add(this.langButton);
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
            this.errorProvider.SetError(this.outputPanel, resources.GetString("outputPanel.Error"));
            this.errorProvider.SetIconAlignment(this.outputPanel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("outputPanel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.outputPanel, ((int)(resources.GetObject("outputPanel.IconPadding"))));
            this.outputPanel.Name = "outputPanel";
            // 
            // langButton
            // 
            resources.ApplyResources(this.langButton, "langButton");
            this.errorProvider.SetError(this.langButton, resources.GetString("langButton.Error"));
            this.errorProvider.SetIconAlignment(this.langButton, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("langButton.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.langButton, ((int)(resources.GetObject("langButton.IconPadding"))));
            this.langButton.Image = global::Sx.Vx.Quipu.WinUI.Properties.Resources.globe_16;
            this.langButton.Name = "langButton";
            this.langButton.UseVisualStyleBackColor = true;
            this.langButton.Click += new System.EventHandler(this.langButton_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.incomeValueLabel);
            this.panel1.Controls.Add(this.incomeCaptionLabel);
            this.errorProvider.SetError(this.panel1, resources.GetString("panel1.Error"));
            this.errorProvider.SetIconAlignment(this.panel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("panel1.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.panel1, ((int)(resources.GetObject("panel1.IconPadding"))));
            this.panel1.Name = "panel1";
            // 
            // incomeValueLabel
            // 
            resources.ApplyResources(this.incomeValueLabel, "incomeValueLabel");
            this.incomeValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "IncomeDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.incomeValueLabel, resources.GetString("incomeValueLabel.Error"));
            this.incomeValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorProvider.SetIconAlignment(this.incomeValueLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("incomeValueLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.incomeValueLabel, ((int)(resources.GetObject("incomeValueLabel.IconPadding"))));
            this.incomeValueLabel.Name = "incomeValueLabel";
            // 
            // incomeCaptionLabel
            // 
            resources.ApplyResources(this.incomeCaptionLabel, "incomeCaptionLabel");
            this.errorProvider.SetError(this.incomeCaptionLabel, resources.GetString("incomeCaptionLabel.Error"));
            this.incomeCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.incomeCaptionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("incomeCaptionLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.incomeCaptionLabel, ((int)(resources.GetObject("incomeCaptionLabel.IconPadding"))));
            this.incomeCaptionLabel.Name = "incomeCaptionLabel";
            // 
            // interestPaymentValueLabel
            // 
            resources.ApplyResources(this.interestPaymentValueLabel, "interestPaymentValueLabel");
            this.interestPaymentValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InterestPaymentDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.interestPaymentValueLabel, resources.GetString("interestPaymentValueLabel.Error"));
            this.interestPaymentValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorProvider.SetIconAlignment(this.interestPaymentValueLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("interestPaymentValueLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.interestPaymentValueLabel, ((int)(resources.GetObject("interestPaymentValueLabel.IconPadding"))));
            this.interestPaymentValueLabel.Name = "interestPaymentValueLabel";
            // 
            // interestPaymentCaptionLabel
            // 
            resources.ApplyResources(this.interestPaymentCaptionLabel, "interestPaymentCaptionLabel");
            this.errorProvider.SetError(this.interestPaymentCaptionLabel, resources.GetString("interestPaymentCaptionLabel.Error"));
            this.interestPaymentCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.interestPaymentCaptionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("interestPaymentCaptionLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.interestPaymentCaptionLabel, ((int)(resources.GetObject("interestPaymentCaptionLabel.IconPadding"))));
            this.interestPaymentCaptionLabel.Name = "interestPaymentCaptionLabel";
            // 
            // interestRateValueLabel
            // 
            resources.ApplyResources(this.interestRateValueLabel, "interestRateValueLabel");
            this.interestRateValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "InterestRateDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.interestRateValueLabel, resources.GetString("interestRateValueLabel.Error"));
            this.interestRateValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorProvider.SetIconAlignment(this.interestRateValueLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("interestRateValueLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.interestRateValueLabel, ((int)(resources.GetObject("interestRateValueLabel.IconPadding"))));
            this.interestRateValueLabel.Name = "interestRateValueLabel";
            // 
            // interestRateCaptionLabel
            // 
            resources.ApplyResources(this.interestRateCaptionLabel, "interestRateCaptionLabel");
            this.errorProvider.SetError(this.interestRateCaptionLabel, resources.GetString("interestRateCaptionLabel.Error"));
            this.interestRateCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.interestRateCaptionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("interestRateCaptionLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.interestRateCaptionLabel, ((int)(resources.GetObject("interestRateCaptionLabel.IconPadding"))));
            this.interestRateCaptionLabel.Name = "interestRateCaptionLabel";
            // 
            // termValueLabel
            // 
            resources.ApplyResources(this.termValueLabel, "termValueLabel");
            this.termValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "TermDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.termValueLabel, resources.GetString("termValueLabel.Error"));
            this.termValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorProvider.SetIconAlignment(this.termValueLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("termValueLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.termValueLabel, ((int)(resources.GetObject("termValueLabel.IconPadding"))));
            this.termValueLabel.Name = "termValueLabel";
            // 
            // termCaptionLabel
            // 
            resources.ApplyResources(this.termCaptionLabel, "termCaptionLabel");
            this.errorProvider.SetError(this.termCaptionLabel, resources.GetString("termCaptionLabel.Error"));
            this.termCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.termCaptionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("termCaptionLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.termCaptionLabel, ((int)(resources.GetObject("termCaptionLabel.IconPadding"))));
            this.termCaptionLabel.Name = "termCaptionLabel";
            // 
            // amountValueLabel
            // 
            resources.ApplyResources(this.amountValueLabel, "amountValueLabel");
            this.amountValueLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AmountDisplayValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.errorProvider.SetError(this.amountValueLabel, resources.GetString("amountValueLabel.Error"));
            this.amountValueLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.errorProvider.SetIconAlignment(this.amountValueLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("amountValueLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.amountValueLabel, ((int)(resources.GetObject("amountValueLabel.IconPadding"))));
            this.amountValueLabel.Name = "amountValueLabel";
            // 
            // amountCaptionLabel
            // 
            resources.ApplyResources(this.amountCaptionLabel, "amountCaptionLabel");
            this.errorProvider.SetError(this.amountCaptionLabel, resources.GetString("amountCaptionLabel.Error"));
            this.amountCaptionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider.SetIconAlignment(this.amountCaptionLabel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("amountCaptionLabel.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.amountCaptionLabel, ((int)(resources.GetObject("amountCaptionLabel.IconPadding"))));
            this.amountCaptionLabel.Name = "amountCaptionLabel";
            // 
            // interestPaymentDataGridView
            // 
            resources.ApplyResources(this.interestPaymentDataGridView, "interestPaymentDataGridView");
            this.interestPaymentDataGridView.AllowUserToAddRows = false;
            this.interestPaymentDataGridView.AllowUserToDeleteRows = false;
            this.interestPaymentDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew;
            this.interestPaymentDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.interestPaymentDataGridView.AutoGenerateColumns = false;
            this.interestPaymentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.interestPaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.interestPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interestPaymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.interestPaymentDataGridView.DataSource = this.incomesBindingSource;
            this.errorProvider.SetError(this.interestPaymentDataGridView, resources.GetString("interestPaymentDataGridView.Error"));
            this.errorProvider.SetIconAlignment(this.interestPaymentDataGridView, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("interestPaymentDataGridView.IconAlignment"))));
            this.errorProvider.SetIconPadding(this.interestPaymentDataGridView, ((int)(resources.GetObject("interestPaymentDataGridView.IconPadding"))));
            this.interestPaymentDataGridView.MultiSelect = false;
            this.interestPaymentDataGridView.Name = "interestPaymentDataGridView";
            this.interestPaymentDataGridView.ReadOnly = true;
            this.interestPaymentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.keyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.keyDataGridViewTextBoxColumn, "keyDataGridViewTextBoxColumn");
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = null;
            this.valueDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.valueDataGridViewTextBoxColumn, "valueDataGridViewTextBoxColumn");
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            this.valueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // incomesBindingSource
            // 
            this.incomesBindingSource.DataMember = "Incomes";
            this.incomesBindingSource.DataSource = this.bindingSource;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // CalculatorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.outputPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.currencyPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
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
        private System.Windows.Forms.Button langButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}

