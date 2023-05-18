﻿namespace Sx.Vx.Quipu.DepositCalculator.WinUI
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
            this.inputPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.interestRateToLabel = new System.Windows.Forms.Label();
            this.interestRateFromLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.interestRateTrackBar = new System.Windows.Forms.TrackBar();
            this.interestPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.termToLabel = new System.Windows.Forms.Label();
            this.termFromLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.termTrackBar = new System.Windows.Forms.TrackBar();
            this.termTextBox = new System.Windows.Forms.TextBox();
            this.amountToLabel = new System.Windows.Forms.Label();
            this.amountFromLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.amountTrackBar = new System.Windows.Forms.TrackBar();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.splitter = new System.Windows.Forms.Splitter();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.interestPaymentDataGridView = new System.Windows.Forms.DataGridView();
            this.incomeValueLabel = new System.Windows.Forms.Label();
            this.incomeCaptionLabel = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountTrackBar)).BeginInit();
            this.outputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestPaymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.label10);
            this.inputPanel.Controls.Add(this.interestRateToLabel);
            this.inputPanel.Controls.Add(this.interestRateFromLabel);
            this.inputPanel.Controls.Add(this.label9);
            this.inputPanel.Controls.Add(this.interestRateTrackBar);
            this.inputPanel.Controls.Add(this.interestPaymentComboBox);
            this.inputPanel.Controls.Add(this.interestRateTextBox);
            this.inputPanel.Controls.Add(this.termToLabel);
            this.inputPanel.Controls.Add(this.termFromLabel);
            this.inputPanel.Controls.Add(this.label6);
            this.inputPanel.Controls.Add(this.termTrackBar);
            this.inputPanel.Controls.Add(this.termTextBox);
            this.inputPanel.Controls.Add(this.amountToLabel);
            this.inputPanel.Controls.Add(this.amountFromLabel);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Controls.Add(this.amountTrackBar);
            this.inputPanel.Controls.Add(this.currencyComboBox);
            this.inputPanel.Controls.Add(this.amountTextBox);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanel.Location = new System.Drawing.Point(0, 0);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(297, 420);
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
            // interestRateToLabel
            // 
            this.interestRateToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.interestRateToLabel.Location = new System.Drawing.Point(182, 327);
            this.interestRateToLabel.Name = "interestRateToLabel";
            this.interestRateToLabel.Size = new System.Drawing.Size(100, 13);
            this.interestRateToLabel.TabIndex = 35;
            this.interestRateToLabel.Text = "To Y $";
            this.interestRateToLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // interestRateFromLabel
            // 
            this.interestRateFromLabel.Location = new System.Drawing.Point(10, 327);
            this.interestRateFromLabel.Name = "interestRateFromLabel";
            this.interestRateFromLabel.Size = new System.Drawing.Size(100, 13);
            this.interestRateFromLabel.TabIndex = 34;
            this.interestRateFromLabel.Text = "From X $";
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
            this.interestRateTrackBar.Location = new System.Drawing.Point(10, 294);
            this.interestRateTrackBar.Name = "interestRateTrackBar";
            this.interestRateTrackBar.Size = new System.Drawing.Size(272, 45);
            this.interestRateTrackBar.TabIndex = 32;
            // 
            // interestPaymentComboBox
            // 
            this.interestPaymentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestPaymentComboBox.FormattingEnabled = true;
            this.interestPaymentComboBox.Location = new System.Drawing.Point(10, 386);
            this.interestPaymentComboBox.Name = "interestPaymentComboBox";
            this.interestPaymentComboBox.Size = new System.Drawing.Size(272, 21);
            this.interestPaymentComboBox.TabIndex = 31;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.interestRateTextBox.Location = new System.Drawing.Point(10, 268);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(272, 20);
            this.interestRateTextBox.TabIndex = 30;
            // 
            // termToLabel
            // 
            this.termToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.termToLabel.Location = new System.Drawing.Point(182, 209);
            this.termToLabel.Name = "termToLabel";
            this.termToLabel.Size = new System.Drawing.Size(100, 13);
            this.termToLabel.TabIndex = 29;
            this.termToLabel.Text = "To Y $";
            this.termToLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // termFromLabel
            // 
            this.termFromLabel.Location = new System.Drawing.Point(10, 209);
            this.termFromLabel.Name = "termFromLabel";
            this.termFromLabel.Size = new System.Drawing.Size(100, 13);
            this.termFromLabel.TabIndex = 28;
            this.termFromLabel.Text = "From X $";
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
            this.termTrackBar.Location = new System.Drawing.Point(10, 176);
            this.termTrackBar.Name = "termTrackBar";
            this.termTrackBar.Size = new System.Drawing.Size(272, 45);
            this.termTrackBar.TabIndex = 26;
            // 
            // termTextBox
            // 
            this.termTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.termTextBox.Location = new System.Drawing.Point(10, 150);
            this.termTextBox.Name = "termTextBox";
            this.termTextBox.Size = new System.Drawing.Size(272, 20);
            this.termTextBox.TabIndex = 25;
            // 
            // amountToLabel
            // 
            this.amountToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountToLabel.Location = new System.Drawing.Point(182, 91);
            this.amountToLabel.Name = "amountToLabel";
            this.amountToLabel.Size = new System.Drawing.Size(100, 13);
            this.amountToLabel.TabIndex = 24;
            this.amountToLabel.Text = "To Y $";
            this.amountToLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // amountFromLabel
            // 
            this.amountFromLabel.Location = new System.Drawing.Point(10, 91);
            this.amountFromLabel.Name = "amountFromLabel";
            this.amountFromLabel.Size = new System.Drawing.Size(100, 13);
            this.amountFromLabel.TabIndex = 23;
            this.amountFromLabel.Text = "From X $";
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
            this.amountTrackBar.Location = new System.Drawing.Point(10, 58);
            this.amountTrackBar.Name = "amountTrackBar";
            this.amountTrackBar.Size = new System.Drawing.Size(281, 45);
            this.amountTrackBar.TabIndex = 21;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(182, 31);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(100, 21);
            this.currencyComboBox.TabIndex = 20;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.Location = new System.Drawing.Point(10, 32);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(166, 20);
            this.amountTextBox.TabIndex = 19;
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter.Location = new System.Drawing.Point(292, 0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(5, 420);
            this.splitter.TabIndex = 21;
            this.splitter.TabStop = false;
            // 
            // outputPanel
            // 
            this.outputPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputPanel.Controls.Add(this.interestPaymentDataGridView);
            this.outputPanel.Controls.Add(this.incomeValueLabel);
            this.outputPanel.Controls.Add(this.incomeCaptionLabel);
            this.outputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.outputPanel.Location = new System.Drawing.Point(297, 0);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(329, 420);
            this.outputPanel.TabIndex = 22;
            // 
            // interestPaymentDataGridView
            // 
            this.interestPaymentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.interestPaymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interestPaymentDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.interestPaymentDataGridView.Location = new System.Drawing.Point(0, 53);
            this.interestPaymentDataGridView.Name = "interestPaymentDataGridView";
            this.interestPaymentDataGridView.Size = new System.Drawing.Size(329, 367);
            this.interestPaymentDataGridView.TabIndex = 26;
            // 
            // incomeValueLabel
            // 
            this.incomeValueLabel.AutoSize = true;
            this.incomeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incomeValueLabel.Location = new System.Drawing.Point(91, 14);
            this.incomeValueLabel.Name = "incomeValueLabel";
            this.incomeValueLabel.Size = new System.Drawing.Size(88, 24);
            this.incomeValueLabel.TabIndex = 25;
            this.incomeValueLabel.Text = "20.000 $";
            // 
            // incomeCaptionLabel
            // 
            this.incomeCaptionLabel.AutoSize = true;
            this.incomeCaptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeCaptionLabel.Location = new System.Drawing.Point(6, 14);
            this.incomeCaptionLabel.Name = "incomeCaptionLabel";
            this.incomeCaptionLabel.Size = new System.Drawing.Size(79, 24);
            this.incomeCaptionLabel.TabIndex = 24;
            this.incomeCaptionLabel.Text = "Income";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 420);
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
            ((System.ComponentModel.ISupportInitialize)(this.interestPaymentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label interestRateToLabel;
        private System.Windows.Forms.Label interestRateFromLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar interestRateTrackBar;
        private System.Windows.Forms.ComboBox interestPaymentComboBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Label termToLabel;
        private System.Windows.Forms.Label termFromLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar termTrackBar;
        private System.Windows.Forms.TextBox termTextBox;
        private System.Windows.Forms.Label amountToLabel;
        private System.Windows.Forms.Label amountFromLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar amountTrackBar;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Label incomeCaptionLabel;
        private System.Windows.Forms.Label incomeValueLabel;
        private System.Windows.Forms.DataGridView interestPaymentDataGridView;
    }
}

