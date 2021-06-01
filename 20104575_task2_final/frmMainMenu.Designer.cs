
namespace _20104575_task2_final
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnHouse = new System.Windows.Forms.Button();
            this.lblIncome = new System.Windows.Forms.Label();
            this.txbIncome = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbDeductions = new System.Windows.Forms.ListBox();
            this.lbExpenses = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpense
            // 
            this.btnExpense.Location = new System.Drawing.Point(226, 202);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(316, 68);
            this.btnExpense.TabIndex = 0;
            this.btnExpense.Text = "Expense";
            this.btnExpense.UseVisualStyleBackColor = true;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(226, 308);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(316, 68);
            this.btnVehicle.TabIndex = 1;
            this.btnVehicle.Text = "Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnHouse
            // 
            this.btnHouse.Location = new System.Drawing.Point(226, 414);
            this.btnHouse.Name = "btnHouse";
            this.btnHouse.Size = new System.Drawing.Size(316, 68);
            this.btnHouse.TabIndex = 2;
            this.btnHouse.Text = "House";
            this.btnHouse.UseVisualStyleBackColor = true;
            this.btnHouse.Click += new System.EventHandler(this.btnHouse_Click);
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(80, 37);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(75, 25);
            this.lblIncome.TabIndex = 3;
            this.lblIncome.Text = "Income:";
            // 
            // txbIncome
            // 
            this.txbIncome.Location = new System.Drawing.Point(178, 37);
            this.txbIncome.Name = "txbIncome";
            this.txbIncome.Size = new System.Drawing.Size(150, 31);
            this.txbIncome.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbDeductions
            // 
            this.lbDeductions.FormattingEnabled = true;
            this.lbDeductions.ItemHeight = 25;
            this.lbDeductions.Location = new System.Drawing.Point(684, 293);
            this.lbDeductions.Name = "lbDeductions";
            this.lbDeductions.Size = new System.Drawing.Size(260, 179);
            this.lbDeductions.TabIndex = 6;
            this.lbDeductions.SelectedIndexChanged += new System.EventHandler(this.lbDeductions_SelectedIndexChanged);
            // 
            // lbExpenses
            // 
            this.lbExpenses.FormattingEnabled = true;
            this.lbExpenses.ItemHeight = 25;
            this.lbExpenses.Location = new System.Drawing.Point(684, 89);
            this.lbExpenses.Name = "lbExpenses";
            this.lbExpenses.Size = new System.Drawing.Size(260, 179);
            this.lbExpenses.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbExpenses);
            this.Controls.Add(this.lbDeductions);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbIncome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.btnHouse);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnExpense);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnHouse;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.TextBox txbIncome;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbDeductions;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbExpenses;
    }
}

