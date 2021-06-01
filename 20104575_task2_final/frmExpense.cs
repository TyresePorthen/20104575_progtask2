using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _20104575_task2_final
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            InitializeComponent();
    }

        private void btnCalcExpense_Click(object sender, EventArgs e)
        {
            try
            {
                string description = txbDescription.Text;
                double groceries = Convert.ToDouble(txbGroceries.Text);
                double waterAndLights = Convert.ToDouble(txbWaterAndLights.Text);
                double travelCosts = Convert.ToDouble(txbTravelCost.Text);
                double cellphoneAndTelephone = Convert.ToDouble(txbCellphone.Text);
                double otherExpenses = Convert.ToDouble(txbOtherExpenses.Text);

                Expense objLV = new Expense(DateTime.Now, description, groceries, waterAndLights, travelCosts, cellphoneAndTelephone, otherExpenses);

                StaticValues.lbExpenses.Add(objLV);

                lblMonthlyExpense.Text = "This is your expenses: R " + objLV.MonthlyExpense;

                StaticValues.currentIncome = StaticValues.currentIncome - objLV.MonthlyExpense;
            }
            catch(Exception)
            {
                MessageBox.Show("Please correct all your fields");
            }
            
        }
    }
}
