using System;
using System.Collections.Generic;
using PersonalBudgetTracker.Models;

namespace PersonalBudgetTracker.Services
{
    public class TransactionManager
    {
        private readonly List<Transaction> transactions;

        public TransactionManager()
        {
            transactions =
                new List<Transaction>();
        }

        public List<Transaction> Transactions
        {
            get
            {
                return new List<Transaction>(
                    transactions);
            }
        }

        public void AddTransaction(
            Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(
                    "transaction");
            }

            transactions.Add(transaction);
        }

        public void DeleteTransaction(Guid id)
        {
            Transaction transactionToDelete = null;

            foreach (Transaction transaction
                in transactions)
            {
                if (transaction.Id == id)
                {
                    transactionToDelete = transaction;
                    break;
                }
            }

            if (transactionToDelete == null)
            {
                throw new InvalidOperationException(
                    "The selected transaction " +
                    "could not be found.");
            }

            transactions.Remove(
                transactionToDelete);
        }

        public decimal CalculateTotalIncome()
        {
            decimal total = 0;

            foreach (Transaction transaction
                in transactions)
            {
                if (transaction
                    is IncomeTransaction)
                {
                    total += transaction.Amount;
                }
            }

            return total;
        }

        public decimal CalculateTotalExpenses()
        {
            decimal total = 0;

            foreach (Transaction transaction
                in transactions)
            {
                if (transaction
                    is ExpenseTransaction)
                {
                    total += transaction.Amount;
                }
            }

            return total;
        }

        public decimal CalculateBalance()
        {
            decimal balance = 0;

            foreach (Transaction transaction
                in transactions)
            {
                balance +=
                    transaction.GetBalanceEffect();
            }

            return balance;
        }

        public void ReplaceTransactions(
            IEnumerable<Transaction> savedTransactions)
        {
            transactions.Clear();

            if (savedTransactions == null)
            {
                return;
            }

            foreach (Transaction transaction
                in savedTransactions)
            {
                transactions.Add(transaction);
            }
        }

        public List<Transaction>
            GetFilteredTransactions(
                string selectedType,
                string selectedCategory)
        {
            List<Transaction> filteredTransactions =
                new List<Transaction>();

            foreach (Transaction transaction
                in transactions)
            {
                bool matchesType =
                    selectedType == "All Types" ||
                    transaction.Type == selectedType;

                bool matchesCategory =
                    selectedCategory == "All Categories" ||
                    transaction.Category ==
                    selectedCategory;

                if (matchesType &&
                    matchesCategory)
                {
                    filteredTransactions.Add(
                        transaction);
                }
            }

            return filteredTransactions;
        }

        public List<Transaction>
            GetFilteredTransactionsByDate(
                string selectedType,
                string selectedCategory,
                DateTime startDate,
                DateTime endDate)
        {
            if (startDate.Date > endDate.Date)
            {
                throw new ArgumentException(
                    "The start date cannot be after " +
                    "the end date.");
            }

            List<Transaction> typeAndCategoryResults =
                GetFilteredTransactions(
                    selectedType,
                    selectedCategory);

            List<Transaction> dateResults =
                new List<Transaction>();

            foreach (Transaction transaction
                in typeAndCategoryResults)
            {
                bool isInsideDateRange =
                    transaction.Date.Date >= startDate.Date &&
                    transaction.Date.Date <= endDate.Date;

                if (isInsideDateRange)
                {
                    dateResults.Add(transaction);
                }
            }

            return dateResults;
        }

        public Dictionary<string, decimal>
            GetExpenseTotalsByCategory()
        {
            Dictionary<string, decimal> categoryTotals =
                new Dictionary<string, decimal>();

            foreach (Transaction transaction
                in transactions)
            {
                if (!(transaction
                    is ExpenseTransaction))
                {
                    continue;
                }

                if (categoryTotals.ContainsKey(
                    transaction.Category))
                {
                    categoryTotals[transaction.Category] +=
                        transaction.Amount;
                }
                else
                {
                    categoryTotals.Add(
                        transaction.Category,
                        transaction.Amount);
                }
            }

            return categoryTotals;
        }

        public void UpdateTransaction(
            Guid id,
            Transaction updatedTransaction)
        {
            if (updatedTransaction == null)
            {
                throw new ArgumentNullException(
                    "updatedTransaction");
            }

            for (int index = 0;
                index < transactions.Count;
                index++)
            {
                if (transactions[index].Id == id)
                {
                    updatedTransaction.Id = id;
                    transactions[index] =
                        updatedTransaction;

                    return;
                }
            }

            throw new InvalidOperationException(
                "The selected transaction could not be found.");
        }
    }
}
