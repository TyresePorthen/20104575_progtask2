using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20104575_task2_final
{
    public partial class frmMainMenu : Form
    {
        private object label12;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            frmExpense fE = new frmExpense();
            this.Hide();
            fE.ShowDialog();
            this.Show();

        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            frmVehicle fV= new frmVehicle();
            this.Hide();
            fV.ShowDialog();
            this.Show();
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            frmHouse fH = new frmHouse();
            this.Hide();
            fH.ShowDialog();
            this.Show();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            btnVehicle.Hide();
            btnHouse.Hide();
            btnExpense.Hide();
        }
        // code adapted from https://www.c-sharpcorner.com/article/save-text-file-c-sharp-example/
        private void btnSave_Click(object sender, EventArgs e)
        {
            StaticValues.income = Convert.ToDouble(txbIncome.Text);
            StaticValues.currentIncome = Convert.ToDouble(txbIncome.Text);
            btnVehicle.Show();
            btnHouse.Show();
            btnExpense.Show();
        }
        
        

        private void lbDeductions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDeductions.Items.Add("-R " + StaticValues.currentIncome);

            lbExpenses.Items.Clear();

            foreach (Expense item in StaticValues.lbExpenses)
            {
                lbExpenses.Items.Add("-R" + item.MonthlyExpense);
            }
        }

        private void btnExit_Click(object sender, EventsArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
