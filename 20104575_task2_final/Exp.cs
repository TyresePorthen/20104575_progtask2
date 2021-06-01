using System;
using System.Collections.Generic;
using System.Text;

namespace _20104575_task2_final 
{ 
 public abstract class Exp // adapted from https://www.w3schools.com/cs/cs_abstract.asp
    {
    protected DateTime date;
    protected string description;
    protected double monthlyExpense;

    public Exp(DateTime date, string description, double monthlyExpense)
    {
        this.date = date;
        this.description = description;

    }

    protected Exp(DateTime date, string description)
    {
        this.date = date;
        this.description = description;
    }

    public DateTime Date { get => date; set => date = value; }
    public string Description { get => description; set => description = value; }
    public double MonthlyExpense { get => monthlyExpense; set => monthlyExpense = value; }

    public abstract double CalcMonthlyExpense();
}
}