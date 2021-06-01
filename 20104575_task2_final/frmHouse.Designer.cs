
namespace _20104575_task2_final
{
    partial class frmHouse
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
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.gbBuy = new System.Windows.Forms.GroupBox();
            this.nudMonths = new System.Windows.Forms.NumericUpDown();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.lblMonths = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txbInterestRate = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.txbPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txbDescriptionRent = new System.Windows.Forms.TextBox();
            this.btnCalBuy = new System.Windows.Forms.Button();
            this.lblDescriptionRent = new System.Windows.Forms.Label();
            this.gbRent = new System.Windows.Forms.GroupBox();
            this.txbRentalAmount = new System.Windows.Forms.TextBox();
            this.txbDescriptionBuy = new System.Windows.Forms.TextBox();
            this.lblRentalAmount = new System.Windows.Forms.Label();
            this.lblDescriptionBuy = new System.Windows.Forms.Label();
            this.CalcRent = new System.Windows.Forms.Button();
            this.lblMonthlyExpenseBuy = new System.Windows.Forms.Label();
            this.lblMonthlyExpenseRent = new System.Windows.Forms.Label();
            this.gbPayment.SuspendLayout();
            this.gbBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).BeginInit();
            this.gbRent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.rbBuy);
            this.gbPayment.Controls.Add(this.rbRent);
            this.gbPayment.Location = new System.Drawing.Point(28, 30);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(228, 114);
            this.gbPayment.TabIndex = 0;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment Method:";
            // 
            // rbBuy
            // 
            this.rbBuy.AutoSize = true;
            this.rbBuy.Location = new System.Drawing.Point(16, 76);
            this.rbBuy.Name = "rbBuy";
            this.rbBuy.Size = new System.Drawing.Size(66, 29);
            this.rbBuy.TabIndex = 1;
            this.rbBuy.TabStop = true;
            this.rbBuy.Text = "Buy";
            this.rbBuy.UseVisualStyleBackColor = true;
            this.rbBuy.CheckedChanged += new System.EventHandler(this.rbBuy_CheckedChanged);
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.Location = new System.Drawing.Point(16, 31);
            this.rbRent.Name = "rbRent";
            this.rbRent.Size = new System.Drawing.Size(72, 29);
            this.rbRent.TabIndex = 0;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "Rent";
            this.rbRent.UseVisualStyleBackColor = true;
            this.rbRent.CheckedChanged += new System.EventHandler(this.rbRent_CheckedChanged);
            // 
            // gbBuy
            // 
            this.gbBuy.Controls.Add(this.lblMonthlyExpenseRent);
            this.gbBuy.Controls.Add(this.nudMonths);
            this.gbBuy.Controls.Add(this.txbDeposit);
            this.gbBuy.Controls.Add(this.lblMonths);
            this.gbBuy.Controls.Add(this.lblDeposit);
            this.gbBuy.Controls.Add(this.txbInterestRate);
            this.gbBuy.Controls.Add(this.lblInterestRate);
            this.gbBuy.Controls.Add(this.txbPurchasePrice);
            this.gbBuy.Controls.Add(this.lblPurchasePrice);
            this.gbBuy.Controls.Add(this.txbDescriptionRent);
            this.gbBuy.Controls.Add(this.btnCalBuy);
            this.gbBuy.Controls.Add(this.lblDescriptionRent);
            this.gbBuy.Location = new System.Drawing.Point(28, 152);
            this.gbBuy.Name = "gbBuy";
            this.gbBuy.Size = new System.Drawing.Size(403, 444);
            this.gbBuy.TabIndex = 1;
            this.gbBuy.TabStop = false;
            this.gbBuy.Text = "Buy:";
            // 
            // nudMonths
            // 
            this.nudMonths.Location = new System.Drawing.Point(220, 266);
            this.nudMonths.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudMonths.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.nudMonths.Name = "nudMonths";
            this.nudMonths.Size = new System.Drawing.Size(150, 31);
            this.nudMonths.TabIndex = 15;
            this.nudMonths.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(220, 210);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(150, 31);
            this.txbDeposit.TabIndex = 13;
            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(48, 266);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(77, 25);
            this.lblMonths.TabIndex = 14;
            this.lblMonths.Text = "Months:";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(48, 210);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(78, 25);
            this.lblDeposit.TabIndex = 12;
            this.lblDeposit.Text = "Deposit:";
            // 
            // txbInterestRate
            // 
            this.txbInterestRate.Location = new System.Drawing.Point(220, 154);
            this.txbInterestRate.Name = "txbInterestRate";
            this.txbInterestRate.Size = new System.Drawing.Size(150, 31);
            this.txbInterestRate.TabIndex = 11;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(48, 154);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(140, 25);
            this.lblInterestRate.TabIndex = 10;
            this.lblInterestRate.Text = "Interest Rate(%):";
            // 
            // txbPurchasePrice
            // 
            this.txbPurchasePrice.Location = new System.Drawing.Point(220, 98);
            this.txbPurchasePrice.Name = "txbPurchasePrice";
            this.txbPurchasePrice.Size = new System.Drawing.Size(150, 31);
            this.txbPurchasePrice.TabIndex = 9;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(48, 98);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(128, 25);
            this.lblPurchasePrice.TabIndex = 8;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // txbDescriptionRent
            // 
            this.txbDescriptionRent.Location = new System.Drawing.Point(220, 42);
            this.txbDescriptionRent.Name = "txbDescriptionRent";
            this.txbDescriptionRent.Size = new System.Drawing.Size(150, 31);
            this.txbDescriptionRent.TabIndex = 7;
            // 
            // btnCalBuy
            // 
            this.btnCalBuy.Location = new System.Drawing.Point(114, 374);
            this.btnCalBuy.Name = "btnCalBuy";
            this.btnCalBuy.Size = new System.Drawing.Size(166, 54);
            this.btnCalBuy.TabIndex = 0;
            this.btnCalBuy.Text = "Calculate Buy";
            this.btnCalBuy.UseVisualStyleBackColor = true;
            this.btnCalBuy.Click += new System.EventHandler(this.btnCalRent_Click);
            // 
            // lblDescriptionRent
            // 
            this.lblDescriptionRent.AutoSize = true;
            this.lblDescriptionRent.Location = new System.Drawing.Point(48, 42);
            this.lblDescriptionRent.Name = "lblDescriptionRent";
            this.lblDescriptionRent.Size = new System.Drawing.Size(106, 25);
            this.lblDescriptionRent.TabIndex = 6;
            this.lblDescriptionRent.Text = "Description:";
            // 
            // gbRent
            // 
            this.gbRent.Controls.Add(this.lblMonthlyExpenseBuy);
            this.gbRent.Controls.Add(this.txbRentalAmount);
            this.gbRent.Controls.Add(this.txbDescriptionBuy);
            this.gbRent.Controls.Add(this.lblRentalAmount);
            this.gbRent.Controls.Add(this.lblDescriptionBuy);
            this.gbRent.Controls.Add(this.CalcRent);
            this.gbRent.Location = new System.Drawing.Point(555, 152);
            this.gbRent.Name = "gbRent";
            this.gbRent.Size = new System.Drawing.Size(397, 444);
            this.gbRent.TabIndex = 2;
            this.gbRent.TabStop = false;
            this.gbRent.Text = "Rent:";
            // 
            // txbRentalAmount
            // 
            this.txbRentalAmount.Location = new System.Drawing.Point(219, 108);
            this.txbRentalAmount.Name = "txbRentalAmount";
            this.txbRentalAmount.Size = new System.Drawing.Size(150, 31);
            this.txbRentalAmount.TabIndex = 5;
            // 
            // txbDescriptionBuy
            // 
            this.txbDescriptionBuy.Location = new System.Drawing.Point(219, 48);
            this.txbDescriptionBuy.Name = "txbDescriptionBuy";
            this.txbDescriptionBuy.Size = new System.Drawing.Size(150, 31);
            this.txbDescriptionBuy.TabIndex = 4;
            // 
            // lblRentalAmount
            // 
            this.lblRentalAmount.AutoSize = true;
            this.lblRentalAmount.Location = new System.Drawing.Point(38, 108);
            this.lblRentalAmount.Name = "lblRentalAmount";
            this.lblRentalAmount.Size = new System.Drawing.Size(130, 25);
            this.lblRentalAmount.TabIndex = 3;
            this.lblRentalAmount.Text = "Rental Amount";
            // 
            // lblDescriptionBuy
            // 
            this.lblDescriptionBuy.AutoSize = true;
            this.lblDescriptionBuy.Location = new System.Drawing.Point(38, 54);
            this.lblDescriptionBuy.Name = "lblDescriptionBuy";
            this.lblDescriptionBuy.Size = new System.Drawing.Size(106, 25);
            this.lblDescriptionBuy.TabIndex = 2;
            this.lblDescriptionBuy.Text = "Description:";
            // 
            // CalcRent
            // 
            this.CalcRent.Location = new System.Drawing.Point(130, 374);
            this.CalcRent.Name = "CalcRent";
            this.CalcRent.Size = new System.Drawing.Size(153, 54);
            this.CalcRent.TabIndex = 1;
            this.CalcRent.Text = "Calculate Rent";
            this.CalcRent.UseVisualStyleBackColor = true;
            this.CalcRent.Click += new System.EventHandler(this.btnCalcBuy_Click);
            // 
            // lblMonthlyExpenseBuy
            // 
            this.lblMonthlyExpenseBuy.AutoSize = true;
            this.lblMonthlyExpenseBuy.Location = new System.Drawing.Point(130, 337);
            this.lblMonthlyExpenseBuy.Name = "lblMonthlyExpenseBuy";
            this.lblMonthlyExpenseBuy.Size = new System.Drawing.Size(151, 25);
            this.lblMonthlyExpenseBuy.TabIndex = 6;
            this.lblMonthlyExpenseBuy.Text = "Monthly Expense:";
            // 
            // lblMonthlyExpenseRent
            // 
            this.lblMonthlyExpenseRent.AutoSize = true;
            this.lblMonthlyExpenseRent.Location = new System.Drawing.Point(114, 337);
            this.lblMonthlyExpenseRent.Name = "lblMonthlyExpenseRent";
            this.lblMonthlyExpenseRent.Size = new System.Drawing.Size(151, 25);
            this.lblMonthlyExpenseRent.TabIndex = 16;
            this.lblMonthlyExpenseRent.Text = "Monthly Expense:";
            // 
            // frmHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 619);
            this.Controls.Add(this.gbRent);
            this.Controls.Add(this.gbBuy);
            this.Controls.Add(this.gbPayment);
            this.Name = "frmHouse";
            this.Text = "frmHouse";
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.gbBuy.ResumeLayout(false);
            this.gbBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonths)).EndInit();
            this.gbRent.ResumeLayout(false);
            this.gbRent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.RadioButton rbRent;
        private System.Windows.Forms.GroupBox gbBuy;
        private System.Windows.Forms.GroupBox gbRent;
        private System.Windows.Forms.Button btnCalBuy;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbDescriptionBuy;
        private System.Windows.Forms.Label lblRentalAmount;
        private System.Windows.Forms.Label lblDescriptionBuy;
        private System.Windows.Forms.Button CalcRent;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txbInterestRate;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.TextBox txbPurchasePrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDescriptionRent;
        private System.Windows.Forms.NumericUpDown nudMonths;
        private System.Windows.Forms.TextBox txbDescriptionRent;
        private System.Windows.Forms.TextBox txbRentalAmount;
        private System.Windows.Forms.Label lblMonthlyExpenseRent;
        private System.Windows.Forms.Label lblMonthlyExpenseBuy;
    }
}