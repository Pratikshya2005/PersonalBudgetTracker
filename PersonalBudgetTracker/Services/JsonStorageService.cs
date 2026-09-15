using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using PersonalBudgetTracker.Models;

namespace PersonalBudgetTracker.Services
{
    public class JsonStorageService
    {
        private readonly string filePath;

        public JsonStorageService()
        {
            string folderPath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "PersonalBudgetTracker");

            Directory.CreateDirectory(folderPath);

            filePath = Path.Combine(
                folderPath,
                "transactions.json");
        }

        public void SaveTransactions(
            List<Transaction> transactions)
        {
            try
            {
                List<StoredTransaction> records =
                    new List<StoredTransaction>();

                foreach (Transaction transaction in transactions)
                {
                    StoredTransaction record =
                        new StoredTransaction();

                    record.Id = transaction.Id;
                    record.Date = transaction.Date;
                    record.Category = transaction.Category;
                    record.Description = transaction.Description;
                    record.Amount = transaction.Amount;
                    record.Type = transaction.Type;

                    records.Add(record);
                }

                JavaScriptSerializer serializer =
                    new JavaScriptSerializer();

                string json =
                    serializer.Serialize(records);

                File.WriteAllText(filePath, json);
            }
            catch (UnauthorizedAccessException)
            {
                throw new InvalidOperationException(
                    "The application does not have permission " +
                    "to save the transaction file.");
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException(
                    "The transaction file could not be saved. " +
                    ex.Message);
            }
        }

        public List<Transaction> LoadTransactions()
        {
            List<Transaction> transactions =
                new List<Transaction>();

            if (!File.Exists(filePath))
            {
                return transactions;
            }

            try
            {
                string json =
                    File.ReadAllText(filePath);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return transactions;
                }

                JavaScriptSerializer serializer =
                    new JavaScriptSerializer();

                List<StoredTransaction> records =
                    serializer.Deserialize
                        <List<StoredTransaction>>(json);

                if (records == null)
                {
                    return transactions;
                }

                foreach (StoredTransaction record in records)
                {
                    Transaction transaction;

                    if (record.Type == "Income")
                    {
                        transaction =
                            new IncomeTransaction(
                                record.Date,
                                record.Category,
                                record.Description,
                                record.Amount);
                    }
                    else
                    {
                        transaction =
                            new ExpenseTransaction(
                                record.Date,
                                record.Category,
                                record.Description,
                                record.Amount);
                    }

                    transaction.Id = record.Id;

                    transactions.Add(transaction);
                }

                return transactions;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException(
                    "The saved transaction data is invalid.");
            }
            catch (IOException ex)
            {
                throw new InvalidOperationException(
                    "The transaction file could not be loaded. " +
                    ex.Message);
            }
        }

        public string GetStorageLocation()
        {
            return filePath;
        }
    }

    public class StoredTransaction
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public string Type { get; set; }

        public StoredTransaction()
        {
            Category = string.Empty;
            Description = string.Empty;
            Type = string.Empty;
        }
    }
}