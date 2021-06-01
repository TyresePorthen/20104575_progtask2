using System;
using System.Collections.Generic;
using System.Text;

namespace _20104575_task2_final
{
    class Expense : Exp
    {
        private double groceries;
        private double waterAndLights;
        private double travelCosts;
        private double cellphoneAndTelephone;
        private double otherExpenses;

        public Expense(DateTime date, string description, double monthlyExpense, double waterAndLights, double travelCosts, double cellphoneAndTelephone, double otherExpenses) : base(date, description, monthlyExpense)
        {
        }

        public Expense(DateTime date,
            string description,
            double monthlyExpense,
            double groceries,
            double waterAndLights,
            double travelCosts,
            double cellphoneAndTelephone,
            double otherExpenses)
            : base(date, description)
        {
            this.groceries = groceries;
            this.waterAndLights = waterAndLights;
            this.travelCosts = travelCosts;
            this.cellphoneAndTelephone = cellphoneAndTelephone;
            this.otherExpenses = otherExpenses;

            this.date = date;
            this.description = description;
            this.monthlyExpense = CalcMonthlyExpense();
        }

        public double Groceries { get => groceries; set => groceries = value; }
        public double WaterAndLights { get => waterAndLights; set => waterAndLights = value; }
        public double TravelCosts { get => travelCosts; set => travelCosts = value; }
        public double CellphoneAndTelephone { get => cellphoneAndTelephone; set => cellphoneAndTelephone = value; }
        public double OtherExpenses { get => otherExpenses; set => otherExpenses = value; }

        public override double CalcMonthlyExpense()
        {
            return groceries + waterAndLights + travelCosts + cellphoneAndTelephone + otherExpenses;

        }

    }
}