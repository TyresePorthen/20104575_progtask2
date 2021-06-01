using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _20104575_task2_final
{
    public partial class frmHouse : Form
    {

        public frmHouse()
        {
            InitializeComponent();

            gbRent.Hide();
            gbBuy.Hide(); 
        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRent.Checked) 
            {
                gbBuy.Show();
                gbRent.Hide();
            }
        }

        private void rbBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuy.Checked)
            {
                gbRent.Show();
                gbBuy.Hide();
            }

        }

        private void btnCalcBuy_Click(object sender, EventArgs e)
        {
            string description = txbDescriptionRent.Text;
            double purchasePrice = Convert.ToDouble(txbPurchasePrice.Text);
            double deposit = Convert.ToDouble(txbDeposit.Text);
            double interestRate = Convert.ToDouble(txbInterestRate);
            int numberOfMonths = (int)numberOfMonths.Value;

            House objH = new House(DateTime.Now, description, deposit, interestRate, numberOfMonths);
            StaticValues.lbExpenses.Add(objH);
            lblMonthlyExpenseBuy.Text = "R " + objH.MonthlyExpense;

            StaticValues.currentIncome = StaticValues.currentIncome - objH.MonthlyExpense;
        }

        // code adapted from https://csharp.hotexamples.com/examples/-/Rent/-/php-rent-class-examples.html
        private void btnCalRent_Click(object sender, EventArgs e)
        {
            string description = txbDescriptionRent.Text;
            double purchasePrice = Convert.ToDouble(txbPurchasePrice.Text);
            double deposit = 0;
            double interestRate = 0;
            int numberOfMonths = 1;

            House objH = new House(DateTime.Now, description, deposit, interestRate, numberOfMonths);
            lblMonthlyExpenseRent.Text = "R " + objH.MonthlyExpense;
        }
    }
}
