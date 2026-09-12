using System;

namespace PersonalBudgetTracker.Models
{
    public class ExpenseTransaction : Transaction
    {
        public override string Type => "Expense";

        public ExpenseTransaction()
        {
        }

        public ExpenseTransaction(
            DateTime date,
            string category,
            string description,
            decimal amount)
            : base(date, category, description, amount)
        {
        }

        public override decimal GetBalanceEffect()
        {
            return -Amount;
        }
    }
}