using System;
using System.Collections.Generic;
using System.Text;

namespace _20104575_task2_final
{ 
class Vehicle : Exp
{
    private string makeAndModel;
    private double purchasePrice;
    private double interestRate;
    private double numberOfMonths;
    private double deposit;
    private double insurance;

        public Vehicle(DateTime date, string description, string makeAndModel, double purchasePrice, double interestRate, double deposit, double insurance) : base(date, description)
        {
        }

        public Vehicle(DateTime date,
        string description,
        double monthlyExpense,
        string makeAndModel,
        double purchasePrice,
        double interestRate,
        double deposit,
        double insurance)
        : base(date, description, monthlyExpense)
    {
        this.makeAndModel = makeAndModel;
        this.purchasePrice = purchasePrice;
        this.interestRate = interestRate;
        this.numberOfMonths = 60;
        this.deposit = deposit;
        this.insurance = insurance;

        this.date = date;
        this.description = description;
        this.monthlyExpense = monthlyExpense;
    }

    public string MakeAndModel { get => makeAndModel; set => makeAndModel = value; }
    public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
    public double InterestRate { get => interestRate; set => interestRate = value; }
    public double NumberOfMonths { get => numberOfMonths; set => numberOfMonths = value; }
    public double Deposits { get => deposit; set => deposit = value; }
    public double Insurance { get => insurance; set => insurance = value; }

    public override double CalcMonthlyExpense()
    {
        //A=P(1+in)

        double P = purchasePrice - deposit;
        double i = interestRate;
        double n = NumberOfMonths;

        //code attributed from https://www.siyavula.com/read/maths/grade-10/finance-and-growth/09-finance-and-growth-03
            double A = P * (1 + i * n);
        return ((A / NumberOfMonths) + insurance);
    }

}
}