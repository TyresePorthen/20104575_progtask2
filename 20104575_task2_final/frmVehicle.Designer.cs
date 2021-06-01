
namespace _20104575_task2_final
{
    partial class frmVehicle
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
            this.lblMakeAndModel = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblInsurance = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txbMakeAndModel = new System.Windows.Forms.TextBox();
            this.txbPurchasePrice = new System.Windows.Forms.TextBox();
            this.txbInterestRate = new System.Windows.Forms.TextBox();
            this.txbDeposit = new System.Windows.Forms.TextBox();
            this.txbInsurance = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblMonthlyExpense = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMakeAndModel
            // 
            this.lblMakeAndModel.AutoSize = true;
            this.lblMakeAndModel.Location = new System.Drawing.Point(207, 68);
            this.lblMakeAndModel.Name = "lblMakeAndModel";
            this.lblMakeAndModel.Size = new System.Drawing.Size(150, 25);
            this.lblMakeAndModel.TabIndex = 0;
            this.lblMakeAndModel.Text = "Make and Model:";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(207, 117);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(128, 25);
            this.lblPurchasePrice.TabIndex = 1;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(207, 166);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(140, 25);
            this.lblInterestRate.TabIndex = 2;
            this.lblInterestRate.Text = "Interest Rate(%):";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(207, 215);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(78, 25);
            this.lblDeposit.TabIndex = 3;
            this.lblDeposit.Text = "Deposit:";
            // 
            // lblInsurance
            // 
            this.lblInsurance.AutoSize = true;
            this.lblInsurance.Location = new System.Drawing.Point(207, 264);
            this.lblInsurance.Name = "lblInsurance";
            this.lblInsurance.Size = new System.Drawing.Size(91, 25);
            this.lblInsurance.TabIndex = 4;
            this.lblInsurance.Text = "Insurance:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(207, 313);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 25);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // txbMakeAndModel
            // 
            this.txbMakeAndModel.Location = new System.Drawing.Point(421, 68);
            this.txbMakeAndModel.Name = "txbMakeAndModel";
            this.txbMakeAndModel.Size = new System.Drawing.Size(150, 31);
            this.txbMakeAndModel.TabIndex = 6;
            // 
            // txbPurchasePrice
            // 
            this.txbPurchasePrice.Location = new System.Drawing.Point(421, 117);
            this.txbPurchasePrice.Name = "txbPurchasePrice";
            this.txbPurchasePrice.Size = new System.Drawing.Size(150, 31);
            this.txbPurchasePrice.TabIndex = 7;
            // 
            // txbInterestRate
            // 
            this.txbInterestRate.Location = new System.Drawing.Point(421, 166);
            this.txbInterestRate.Name = "txbInterestRate";
            this.txbInterestRate.Size = new System.Drawing.Size(150, 31);
            this.txbInterestRate.TabIndex = 8;
            // 
            // txbDeposit
            // 
            this.txbDeposit.Location = new System.Drawing.Point(421, 215);
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.Size = new System.Drawing.Size(150, 31);
            this.txbDeposit.TabIndex = 9;
            // 
            // txbInsurance
            // 
            this.txbInsurance.Location = new System.Drawing.Point(421, 264);
            this.txbInsurance.Name = "txbInsurance";
            this.txbInsurance.Size = new System.Drawing.Size(150, 31);
            this.txbInsurance.TabIndex = 10;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(421, 313);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(150, 31);
            this.txbDescription.TabIndex = 11;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(288, 379);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(185, 59);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblMonthlyExpense
            // 
            this.lblMonthlyExpense.AutoSize = true;
            this.lblMonthlyExpense.Location = new System.Drawing.Point(207, 458);
            this.lblMonthlyExpense.Name = "lblMonthlyExpense";
            this.lblMonthlyExpense.Size = new System.Drawing.Size(151, 25);
            this.lblMonthlyExpense.TabIndex = 13;
            this.lblMonthlyExpense.Text = "Monthly Expense:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(664, 458);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMonthlyExpense);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbInsurance);
            this.Controls.Add(this.txbDeposit);
            this.Controls.Add(this.txbInterestRate);
            this.Controls.Add(this.txbPurchasePrice);
            this.Controls.Add(this.txbMakeAndModel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblInsurance);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblMakeAndModel);
            this.Name = "frmVehicle";
            this.Text = "frmVehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMakeAndModel;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txbMakeAndModel;
        private System.Windows.Forms.TextBox txbPurchasePrice;
        private System.Windows.Forms.TextBox txbInterestRate;
        private System.Windows.Forms.TextBox txbDeposit;
        private System.Windows.Forms.TextBox txbInsurance;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblMonthlyExpense;
        private System.Windows.Forms.Button btnBack;
    }
}