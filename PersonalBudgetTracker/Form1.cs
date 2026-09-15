using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PersonalBudgetTracker.Models;
using PersonalBudgetTracker.Services;

namespace PersonalBudgetTracker
{
    public partial class Form1 : Form
    {
        private readonly TransactionManager transactionManager;

        private readonly JsonStorageService storageService;

        public Form1()
        {
            transactionManager =
                new TransactionManager();

            storageService =
                new JsonStorageService();

            InitializeComponent();
            ConfigureForm();
            LoadSavedTransactions();
            RefreshTransactionGrid();
        }

        private void ConfigureForm()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("Income");
            cmbType.Items.Add("Expense");
            cmbType.SelectedIndex = 0;

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Salary");
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Transport");
            cmbCategory.Items.Add("Bills");
            cmbCategory.Items.Add("Entertainment");
            cmbCategory.Items.Add("Other");
            cmbCategory.SelectedIndex = 0;

            dtpDate.Value = DateTime.Today;
        }

        private void LoadSavedTransactions()
        {
            try
            {
                List<Transaction> savedTransactions =
                    storageService.LoadTransactions();

                transactionManager.ReplaceTransactions(
                    savedTransactions);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Previously saved transactions could not " +
                    "be loaded.\n\n" + ex.Message,
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void SaveTransactions()
        {
            storageService.SaveTransactions(
                transactionManager.Transactions);
        }

        private void btnAdd_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                ValidateTransactionInput();

                Transaction transaction;

                if (cmbType.Text == "Income")
                {
                    transaction =
                        new IncomeTransaction(
                            dtpDate.Value.Date,
                            cmbCategory.Text,
                            txtDescription.Text.Trim(),
                            nudAmount.Value);
                }
                else
                {
                    transaction =
                        new ExpenseTransaction(
                            dtpDate.Value.Date,
                            cmbCategory.Text,
                            txtDescription.Text.Trim(),
                            nudAmount.Value);
                }

                transactionManager.AddTransaction(
                    transaction);

                SaveTransactions();
                RefreshTransactionGrid();
                ClearInputs();

                MessageBox.Show(
                    "Transaction added successfully.",
                    "Transaction Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "The transaction could not be saved.\n\n" +
                    ex.Message,
                    "Application Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvTransactions.CurrentRow == null)
                {
                    throw new InvalidOperationException(
                        "Please select a transaction to delete.");
                }

                object idValue =
                    dgvTransactions
                        .CurrentRow
                        .Cells["Id"]
                        .Value;

                if (idValue == null)
                {
                    throw new InvalidOperationException(
                        "The selected transaction is invalid.");
                }

                Guid transactionId =
                    (Guid)idValue;

                DialogResult answer =
                    MessageBox.Show(
                        "Are you sure you want to delete " +
                        "this transaction?",
                        "Delete Transaction",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (answer != DialogResult.Yes)
                {
                    return;
                }

                transactionManager.DeleteTransaction(
                    transactionId);

                SaveTransactions();
                RefreshTransactionGrid();

                MessageBox.Show(
                    "Transaction deleted successfully.",
                    "Transaction Deleted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ValidateTransactionInput()
        {
            if (cmbType.SelectedIndex == -1)
            {
                throw new ArgumentException(
                    "Please select a transaction type.");
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                throw new ArgumentException(
                    "Please select a category.");
            }

            if (string.IsNullOrWhiteSpace(
                txtDescription.Text))
            {
                throw new ArgumentException(
                    "Please enter a transaction description.");
            }

            if (nudAmount.Value <= 0)
            {
                throw new ArgumentException(
                    "The transaction amount must be " +
                    "greater than zero.");
            }
        }

        private void RefreshTransactionGrid()
        {
            dgvTransactions.DataSource = null;

            dgvTransactions.DataSource =
                transactionManager
                    .Transactions
                    .Select(item => new
                    {
                        item.Id,
                        Date =
                            item.Date.ToShortDateString(),
                        item.Type,
                        item.Category,
                        item.Description,
                        item.Amount
                    })
                    .ToList();

            if (dgvTransactions.Columns["Id"] != null)
            {
                dgvTransactions
                    .Columns["Id"]
                    .Visible = false;
            }

            if (dgvTransactions.Columns["Amount"] != null)
            {
                dgvTransactions
                    .Columns["Amount"]
                    .DefaultCellStyle
                    .Format = "C2";
            }

            RefreshSummary();
        }

        private void RefreshSummary()
        {
            decimal totalIncome =
                transactionManager
                    .CalculateTotalIncome();

            decimal totalExpenses =
                transactionManager
                    .CalculateTotalExpenses();

            decimal balance =
                transactionManager
                    .CalculateBalance();

            lblTotalIncome.Text =
                "Total Income: " +
                totalIncome.ToString("C2");

            lblTotalExpenses.Text =
                "Total Expenses: " +
                totalExpenses.ToString("C2");

            lblBalance.Text =
                "Current Balance: " +
                balance.ToString("C2");
        }

        private void ClearInputs()
        {
            dtpDate.Value =
                DateTime.Today;

            cmbType.SelectedIndex =
                0;

            cmbCategory.SelectedIndex =
                0;

            txtDescription.Clear();

            nudAmount.Value =
                0;

            txtDescription.Focus();
        }
    }
}