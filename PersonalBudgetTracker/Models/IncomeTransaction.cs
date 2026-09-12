using System;

namespace PersonalBudgetTracker.Models
{
    public class IncomeTransaction : Transaction
    {
        public override string Type => "Income";

        public IncomeTransaction()
        {
        }

        public IncomeTransaction(
            DateTime date,
            string category,
            string description,
            decimal amount)
            : base(date, category, description, amount)
        {
        }

        public override decimal GetBalanceEffect()
        {
            return Amount;
        }
    }
}