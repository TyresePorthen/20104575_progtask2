
namespace _20104575_task2_final
{
    partial class frmExpense
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
            this.lblWaterAndLights = new System.Windows.Forms.Label();
            this.lblTravelCost = new System.Windows.Forms.Label();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.lblGroceries = new System.Windows.Forms.Label();
            this.lblOtherExpenses = new System.Windows.Forms.Label();
            this.txbGroceries = new System.Windows.Forms.TextBox();
            this.txbWaterAndLights = new System.Windows.Forms.TextBox();
            this.txbTravelCost = new System.Windows.Forms.TextBox();
            this.txbCellphone = new System.Windows.Forms.TextBox();
            this.txbOtherExpenses = new System.Windows.Forms.TextBox();
            this.btnCalcExpense = new System.Windows.Forms.Button();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblMonthlyExpense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWaterAndLights
            // 
            this.lblWaterAndLights.AutoSize = true;
            this.lblWaterAndLights.Location = new System.Drawing.Point(191, 152);
            this.lblWaterAndLights.Name = "lblWaterAndLights";
            this.lblWaterAndLights.Size = new System.Drawing.Size(145, 25);
            this.lblWaterAndLights.TabIndex = 0;
            this.lblWaterAndLights.Text = "Water and lights:";
            // 
            // lblTravelCost
            // 
            this.lblTravelCost.AutoSize = true;
            this.lblTravelCost.Location = new System.Drawing.Point(191, 198);
            this.lblTravelCost.Name = "lblTravelCost";
            this.lblTravelCost.Size = new System.Drawing.Size(101, 25);
            this.lblTravelCost.TabIndex = 1;
            this.lblTravelCost.Text = "Travel Cost:";
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(191, 244);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(215, 25);
            this.lblCellphone.TabIndex = 2;
            this.lblCellphone.Text = "Cellphone and Telephone:";
            // 
            // lblGroceries
            // 
            this.lblGroceries.AutoSize = true;
            this.lblGroceries.Location = new System.Drawing.Point(191, 106);
            this.lblGroceries.Name = "lblGroceries";
            this.lblGroceries.Size = new System.Drawing.Size(89, 25);
            this.lblGroceries.TabIndex = 3;
            this.lblGroceries.Text = "Groceries:";
            // 
            // lblOtherExpenses
            // 
            this.lblOtherExpenses.AutoSize = true;
            this.lblOtherExpenses.Location = new System.Drawing.Point(191, 290);
            this.lblOtherExpenses.Name = "lblOtherExpenses";
            this.lblOtherExpenses.Size = new System.Drawing.Size(138, 25);
            this.lblOtherExpenses.TabIndex = 4;
            this.lblOtherExpenses.Text = "Other Expenses:";
            // 
            // txbGroceries
            // 
            this.txbGroceries.Location = new System.Drawing.Point(477, 103);
            this.txbGroceries.Name = "txbGroceries";
            this.txbGroceries.Size = new System.Drawing.Size(150, 31);
            this.txbGroceries.TabIndex = 5;
            // 
            // txbWaterAndLights
            // 
            this.txbWaterAndLights.Location = new System.Drawing.Point(477, 150);
            this.txbWaterAndLights.Name = "txbWaterAndLights";
            this.txbWaterAndLights.Size = new System.Drawing.Size(150, 31);
            this.txbWaterAndLights.TabIndex = 6;
            // 
            // txbTravelCost
            // 
            this.txbTravelCost.Location = new System.Drawing.Point(477, 197);
            this.txbTravelCost.Name = "txbTravelCost";
            this.txbTravelCost.Size = new System.Drawing.Size(150, 31);
            this.txbTravelCost.TabIndex = 7;
            // 
            // txbCellphone
            // 
            this.txbCellphone.Location = new System.Drawing.Point(477, 244);
            this.txbCellphone.Name = "txbCellphone";
            this.txbCellphone.Size = new System.Drawing.Size(150, 31);
            this.txbCellphone.TabIndex = 8;
            // 
            // txbOtherExpenses
            // 
            this.txbOtherExpenses.Location = new System.Drawing.Point(477, 291);
            this.txbOtherExpenses.Name = "txbOtherExpenses";
            this.txbOtherExpenses.Size = new System.Drawing.Size(150, 31);
            this.txbOtherExpenses.TabIndex = 9;
            // 
            // btnCalcExpense
            // 
            this.btnCalcExpense.Location = new System.Drawing.Point(289, 374);
            this.btnCalcExpense.Name = "btnCalcExpense";
            this.btnCalcExpense.Size = new System.Drawing.Size(213, 46);
            this.btnCalcExpense.TabIndex = 10;
            this.btnCalcExpense.Text = "Calculate Expenses";
            this.btnCalcExpense.UseVisualStyleBackColor = true;
            this.btnCalcExpense.Click += new System.EventHandler(this.btnCalcExpense_Click);
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(477, 54);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(150, 31);
            this.txbDescription.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(191, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(106, 25);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Description:";
            // 
            // lblMonthlyExpense
            // 
            this.lblMonthlyExpense.AutoSize = true;
            this.lblMonthlyExpense.Location = new System.Drawing.Point(191, 452);
            this.lblMonthlyExpense.Name = "lblMonthlyExpense";
            this.lblMonthlyExpense.Size = new System.Drawing.Size(151, 25);
            this.lblMonthlyExpense.TabIndex = 13;
            this.lblMonthlyExpense.Text = "Monthly Expense:";
            // 
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.lblMonthlyExpense);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCalcExpense);
            this.Controls.Add(this.txbOtherExpenses);
            this.Controls.Add(this.txbCellphone);
            this.Controls.Add(this.txbTravelCost);
            this.Controls.Add(this.txbWaterAndLights);
            this.Controls.Add(this.txbGroceries);
            this.Controls.Add(this.lblOtherExpenses);
            this.Controls.Add(this.lblGroceries);
            this.Controls.Add(this.lblCellphone);
            this.Controls.Add(this.lblTravelCost);
            this.Controls.Add(this.lblWaterAndLights);
            this.Name = "frmExpense";
            this.Text = "frmExpense";
            this.Load += new System.EventHandler(this.frmExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWaterAndLights;
        private System.Windows.Forms.Label lblTravelCost;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Label lblGroceries;
        private System.Windows.Forms.Label lblOtherExpenses;
        private System.Windows.Forms.TextBox txbGroceries;
        private System.Windows.Forms.TextBox txbWaterAndLights;
        private System.Windows.Forms.TextBox txbTravelCost;
        private System.Windows.Forms.TextBox txbCellphone;
        private System.Windows.Forms.TextBox txbOtherExpenses;
        private System.Windows.Forms.Button btnCalcExpense;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblMonthlyExpense;
    }
}