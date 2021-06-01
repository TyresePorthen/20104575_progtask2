using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _20104575_task2_final
{
    public partial class frmVehicle : Form
    {
        public frmVehicle()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            string description = txbDescription.Text;
            string makeAndModel = txbMakeAndModel.Text;
            double purchasePrice = Convert.ToDouble(txbPurchasePrice.Text);
            double interestRate = Convert.ToDouble(txbInterestRate.Text);
            double deposit = Convert.ToDouble(txbDeposit.Text);
            double insurance = Convert.ToDouble(txbInsurance.Text);

            Vehicle objBL = new Vehicle(DateTime.Now, description, makeAndModel, purchasePrice, interestRate, deposit, insurance);
            StaticValues.lbExpenses.Add(objBL);
            lblMonthlyExpense.Text = "Vehicle Expense: R " + objBL.MonthlyExpense;

            StaticValues.currentIncome = StaticValues.currentIncome - objBL.MonthlyExpense;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
