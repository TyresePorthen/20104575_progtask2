 using System;
using System.Collections.Generic;
using System.Text;

namespace _20104575_task2_final
{ 
class House : Exp
{
    private double purchasePrice;
    private double deposit;
    private double interestRate;
    private int numOfMonths; //(bet 240 & 360) 

        public House(DateTime date, string description, double monthlyExpense, double interestRate, int numberOfMonths) : base(date, description, monthlyExpense)
        {
        }

        public House(DateTime date,
        string description,
        double purchasePrice,
        double deposit,
        double interestRate,
        int numOfMonths) : base(date, description)
    {
        this.purchasePrice = purchasePrice;
        this.deposit = deposit;
        this.interestRate = interestRate;
        this.numOfMonths = numOfMonths;

        this.date = date;
        this.description = description;
        this.monthlyExpense = CalcMonthlyExpense();


    }

    public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
    public double Deposit { get => deposit; set => deposit = value; }
    public double InterestRate { get => interestRate; set => interestRate = value; }
    public int NumberOfMonths { get => numOfMonths; set => numOfMonths = value; }

    public override double CalcMonthlyExpense()
    {
        //A=P(1+in)

        double P = purchasePrice - deposit;
        double i = interestRate;
        double n = NumberOfMonths;
            //code attributed from https://www.siyavula.com/read/maths/grade-10/finance-and-growth/09-finance-and-growth-03
            double A = P * (1 + i * n);
        return (A / NumberOfMonths);
    }

}
}