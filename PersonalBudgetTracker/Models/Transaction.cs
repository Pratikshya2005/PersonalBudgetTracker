using System;

namespace PersonalBudgetTracker.Models
{
    public abstract class Transaction
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Date { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }

        public abstract string Type { get; }

        protected Transaction()
        {
        }

        protected Transaction(
            DateTime date,
            string category,
            string description,
            decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be greater than zero.");

            Date = date;
            Category = category;
            Description = description;
            Amount = amount;
        }

        public abstract decimal GetBalanceEffect();
    }
}