namespace Quinn_Currency_Exchange
{
    partial class Form1
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
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.deliveryGroupBox = new System.Windows.Forms.GroupBox();
            this.passportRadioButton = new System.Windows.Forms.RadioButton();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startingListBox = new System.Windows.Forms.ListBox();
            this.endingListBox = new System.Windows.Forms.ListBox();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.startingValueLabel = new System.Windows.Forms.Label();
            this.endingValueLabel = new System.Windows.Forms.Label();
            this.conversionRateLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.passportFeeLabel = new System.Windows.Forms.Label();
            this.deliveryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(13, 34);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(81, 29);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 0;
            // 
            // deliveryGroupBox
            // 
            this.deliveryGroupBox.Controls.Add(this.passportRadioButton);
            this.deliveryGroupBox.Controls.Add(this.cashRadioButton);
            this.deliveryGroupBox.Location = new System.Drawing.Point(261, 12);
            this.deliveryGroupBox.Name = "deliveryGroupBox";
            this.deliveryGroupBox.Size = new System.Drawing.Size(111, 73);
            this.deliveryGroupBox.TabIndex = 2;
            this.deliveryGroupBox.TabStop = false;
            this.deliveryGroupBox.Text = "Delivery";
            // 
            // passportRadioButton
            // 
            this.passportRadioButton.AutoSize = true;
            this.passportRadioButton.Location = new System.Drawing.Point(7, 44);
            this.passportRadioButton.Name = "passportRadioButton";
            this.passportRadioButton.Size = new System.Drawing.Size(93, 17);
            this.passportRadioButton.TabIndex = 4;
            this.passportRadioButton.Text = "Cash Passport";
            this.passportRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Checked = true;
            this.cashRadioButton.Location = new System.Drawing.Point(7, 20);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(49, 17);
            this.cashRadioButton.TabIndex = 3;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(297, 128);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "Check &Rate";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Enabled = false;
            this.buyButton.Location = new System.Drawing.Point(297, 157);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 6;
            this.buyButton.Text = "&Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(297, 186);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startingListBox
            // 
            this.startingListBox.FormattingEnabled = true;
            this.startingListBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.startingListBox.Location = new System.Drawing.Point(16, 68);
            this.startingListBox.Name = "startingListBox";
            this.startingListBox.Size = new System.Drawing.Size(40, 43);
            this.startingListBox.TabIndex = 1;
            // 
            // endingListBox
            // 
            this.endingListBox.FormattingEnabled = true;
            this.endingListBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.endingListBox.Location = new System.Drawing.Point(174, 68);
            this.endingListBox.Name = "endingListBox";
            this.endingListBox.Size = new System.Drawing.Size(40, 43);
            this.endingListBox.TabIndex = 2;
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(13, 127);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(0, 13);
            this.transactionLabel.TabIndex = 8;
            this.transactionLabel.Visible = false;
            // 
            // startingValueLabel
            // 
            this.startingValueLabel.AutoSize = true;
            this.startingValueLabel.Location = new System.Drawing.Point(13, 156);
            this.startingValueLabel.Name = "startingValueLabel";
            this.startingValueLabel.Size = new System.Drawing.Size(0, 13);
            this.startingValueLabel.TabIndex = 9;
            this.startingValueLabel.Visible = false;
            // 
            // endingValueLabel
            // 
            this.endingValueLabel.AutoSize = true;
            this.endingValueLabel.Location = new System.Drawing.Point(12, 185);
            this.endingValueLabel.Name = "endingValueLabel";
            this.endingValueLabel.Size = new System.Drawing.Size(0, 13);
            this.endingValueLabel.TabIndex = 10;
            this.endingValueLabel.Visible = false;
            // 
            // conversionRateLabel
            // 
            this.conversionRateLabel.AutoSize = true;
            this.conversionRateLabel.Location = new System.Drawing.Point(13, 214);
            this.conversionRateLabel.Name = "conversionRateLabel";
            this.conversionRateLabel.Size = new System.Drawing.Size(0, 13);
            this.conversionRateLabel.TabIndex = 11;
            this.conversionRateLabel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(297, 216);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // passportFeeLabel
            // 
            this.passportFeeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passportFeeLabel.AutoSize = true;
            this.passportFeeLabel.Location = new System.Drawing.Point(220, 98);
            this.passportFeeLabel.Name = "passportFeeLabel";
            this.passportFeeLabel.Size = new System.Drawing.Size(0, 13);
            this.passportFeeLabel.TabIndex = 13;
            this.passportFeeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 251);
            this.Controls.Add(this.passportFeeLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.conversionRateLabel);
            this.Controls.Add(this.endingValueLabel);
            this.Controls.Add(this.startingValueLabel);
            this.Controls.Add(this.transactionLabel);
            this.Controls.Add(this.endingListBox);
            this.Controls.Add(this.startingListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.deliveryGroupBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.amountLabel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 290);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quinn Currency Exchange";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.deliveryGroupBox.ResumeLayout(false);
            this.deliveryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.GroupBox deliveryGroupBox;
        private System.Windows.Forms.RadioButton passportRadioButton;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox startingListBox;
        private System.Windows.Forms.ListBox endingListBox;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.Label startingValueLabel;
        private System.Windows.Forms.Label endingValueLabel;
        private System.Windows.Forms.Label conversionRateLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label passportFeeLabel;
    }
}

