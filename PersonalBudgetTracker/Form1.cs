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

        private Button btnUpdate;

        private Button btnCategorySummary;

        private CheckBox chkUseDateFilter;

        private DateTimePicker dtpFilterStart;

        private DateTimePicker dtpFilterEnd;

        public Form1()
        {
            transactionManager =
                new TransactionManager();

            storageService =
                new JsonStorageService();

            InitializeComponent();
            ConfigureEditFeature();
            ConfigureDateFilterFeature();
            ConfigureCategorySummaryFeature();
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

            cmbFilterType.Items.Clear();
            cmbFilterType.Items.Add("All Types");
            cmbFilterType.Items.Add("Income");
            cmbFilterType.Items.Add("Expense");
            cmbFilterType.SelectedIndex = 0;

            cmbFilterCategory.Items.Clear();
            cmbFilterCategory.Items.Add("All Categories");
            cmbFilterCategory.Items.Add("Salary");
            cmbFilterCategory.Items.Add("Food");
            cmbFilterCategory.Items.Add("Transport");
            cmbFilterCategory.Items.Add("Bills");
            cmbFilterCategory.Items.Add("Entertainment");
            cmbFilterCategory.Items.Add("Other");
            cmbFilterCategory.SelectedIndex = 0;

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

        private void cmbFilter_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbFilterType.SelectedIndex == -1 ||
                cmbFilterCategory.SelectedIndex == -1)
            {
                return;
            }

            RefreshTransactionGrid();
        }

        private void btnClearFilter_Click(
            object sender,
            EventArgs e)
        {
            cmbFilterType.SelectedIndex = 0;
            cmbFilterCategory.SelectedIndex = 0;

            RefreshTransactionGrid();
        }

        private void ConfigureEditFeature()
        {
            btnUpdate = new Button();
            btnUpdate.Location =
                new System.Drawing.Point(640, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size =
                new System.Drawing.Size(135, 29);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update Selected";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click +=
                new EventHandler(btnUpdate_Click);

            Controls.Add(btnUpdate);

            dgvTransactions.CellClick +=
                new DataGridViewCellEventHandler(
                    dgvTransactions_CellClick);
        }

        private void ConfigureDateFilterFeature()
        {
            dgvTransactions.Location =
                new System.Drawing.Point(25, 235);
            dgvTransactions.Size =
                new System.Drawing.Size(888, 252);

            chkUseDateFilter = new CheckBox();
            chkUseDateFilter.Location =
                new System.Drawing.Point(25, 201);
            chkUseDateFilter.Size =
                new System.Drawing.Size(125, 24);
            chkUseDateFilter.Text = "Use date range";

            Label lblFrom = new Label();
            lblFrom.AutoSize = true;
            lblFrom.Location =
                new System.Drawing.Point(160, 204);
            lblFrom.Text = "From";

            dtpFilterStart = new DateTimePicker();
            dtpFilterStart.Format =
                DateTimePickerFormat.Short;
            dtpFilterStart.Location =
                new System.Drawing.Point(205, 200);
            dtpFilterStart.Size =
                new System.Drawing.Size(125, 22);
            dtpFilterStart.Value =
                new DateTime(
                    DateTime.Today.Year,
                    DateTime.Today.Month,
                    1);
            dtpFilterStart.Enabled = false;

            Label lblTo = new Label();
            lblTo.AutoSize = true;
            lblTo.Location =
                new System.Drawing.Point(345, 204);
            lblTo.Text = "To";

            dtpFilterEnd = new DateTimePicker();
            dtpFilterEnd.Format =
                DateTimePickerFormat.Short;
            dtpFilterEnd.Location =
                new System.Drawing.Point(375, 200);
            dtpFilterEnd.Size =
                new System.Drawing.Size(125, 22);
            dtpFilterEnd.Value = DateTime.Today;
            dtpFilterEnd.Enabled = false;

            chkUseDateFilter.CheckedChanged +=
                new EventHandler(dateFilter_Changed);
            dtpFilterStart.ValueChanged +=
                new EventHandler(dateFilter_Changed);
            dtpFilterEnd.ValueChanged +=
                new EventHandler(dateFilter_Changed);

            Controls.Add(chkUseDateFilter);
            Controls.Add(lblFrom);
            Controls.Add(dtpFilterStart);
            Controls.Add(lblTo);
            Controls.Add(dtpFilterEnd);
        }

        private void dateFilter_Changed(
            object sender,
            EventArgs e)
        {
            dtpFilterStart.Enabled =
                chkUseDateFilter.Checked;
            dtpFilterEnd.Enabled =
                chkUseDateFilter.Checked;

            if (chkUseDateFilter.Checked &&
                dtpFilterStart.Value.Date >
                dtpFilterEnd.Value.Date)
            {
                return;
            }

            RefreshTransactionGrid();
        }

        private void ConfigureCategorySummaryFeature()
        {
            btnCategorySummary = new Button();
            btnCategorySummary.Location =
                new System.Drawing.Point(520, 198);
            btnCategorySummary.Size =
                new System.Drawing.Size(160, 28);
            btnCategorySummary.Text =
                "Expense Summary";
            btnCategorySummary.UseVisualStyleBackColor =
                true;
            btnCategorySummary.Click +=
                new EventHandler(
                    btnCategorySummary_Click);

            Controls.Add(btnCategorySummary);
        }

        private void btnCategorySummary_Click(
            object sender,
            EventArgs e)
        {
            Dictionary<string, decimal> categoryTotals =
                transactionManager
                    .GetExpenseTotalsByCategory();

            if (categoryTotals.Count == 0)
            {
                MessageBox.Show(
                    "There are no expense transactions " +
                    "to summarise.",
                    "Expense Summary",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            string summaryText =
                "Expense totals by category:\n\n";

            foreach (KeyValuePair<string, decimal> item
                in categoryTotals)
            {
                summaryText +=
                    item.Key + ": " +
                    item.Value.ToString("C2") +
                    "\n";
            }

            MessageBox.Show(
                summaryText,
                "Expense Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dgvTransactions_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow selectedRow =
                dgvTransactions.Rows[e.RowIndex];

            object dateValue =
                selectedRow.Cells["Date"].Value;
            object typeValue =
                selectedRow.Cells["Type"].Value;
            object categoryValue =
                selectedRow.Cells["Category"].Value;
            object descriptionValue =
                selectedRow.Cells["Description"].Value;
            object amountValue =
                selectedRow.Cells["Amount"].Value;

            if (dateValue != null)
            {
                dtpDate.Value =
                    Convert.ToDateTime(dateValue);
            }

            if (typeValue != null)
            {
                cmbType.SelectedItem =
                    typeValue.ToString();
            }

            if (categoryValue != null)
            {
                cmbCategory.SelectedItem =
                    categoryValue.ToString();
            }

            txtDescription.Text =
                descriptionValue == null
                    ? string.Empty
                    : descriptionValue.ToString();

            if (amountValue != null)
            {
                nudAmount.Value =
                    Convert.ToDecimal(amountValue);
            }
        }

        private void btnUpdate_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvTransactions.CurrentRow == null)
                {
                    throw new InvalidOperationException(
                        "Please select a transaction to update.");
                }

                ValidateTransactionInput();

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

                Transaction updatedTransaction;

                if (cmbType.Text == "Income")
                {
                    updatedTransaction =
                        new IncomeTransaction(
                            dtpDate.Value.Date,
                            cmbCategory.Text,
                            txtDescription.Text.Trim(),
                            nudAmount.Value);
                }
                else
                {
                    updatedTransaction =
                        new ExpenseTransaction(
                            dtpDate.Value.Date,
                            cmbCategory.Text,
                            txtDescription.Text.Trim(),
                            nudAmount.Value);
                }

                transactionManager.UpdateTransaction(
                    transactionId,
                    updatedTransaction);

                SaveTransactions();
                RefreshTransactionGrid();
                ClearInputs();

                MessageBox.Show(
                    "Transaction updated successfully.",
                    "Transaction Updated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Unable to Update",
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
            string selectedType =
                cmbFilterType.SelectedIndex == -1
                    ? "All Types"
                    : cmbFilterType.Text;

            string selectedCategory =
                cmbFilterCategory.SelectedIndex == -1
                    ? "All Categories"
                    : cmbFilterCategory.Text;

            List<Transaction> filteredTransactions;

            if (chkUseDateFilter.Checked)
            {
                filteredTransactions =
                    transactionManager
                        .GetFilteredTransactionsByDate(
                            selectedType,
                            selectedCategory,
                            dtpFilterStart.Value.Date,
                            dtpFilterEnd.Value.Date);
            }
            else
            {
                filteredTransactions =
                    transactionManager
                        .GetFilteredTransactions(
                            selectedType,
                            selectedCategory);
            }

            dgvTransactions.DataSource = null;

            dgvTransactions.DataSource =
                filteredTransactions
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

            RefreshSummary(filteredTransactions);
        }

        private void RefreshSummary(
            List<Transaction> displayedTransactions)
        {
            decimal totalIncome = 0;
            decimal totalExpenses = 0;
            decimal balance = 0;

            foreach (Transaction transaction
                in displayedTransactions)
            {
                if (transaction is IncomeTransaction)
                {
                    totalIncome += transaction.Amount;
                }
                else if (transaction
                    is ExpenseTransaction)
                {
                    totalExpenses += transaction.Amount;
                }

                balance +=
                    transaction.GetBalanceEffect();
            }

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
            dtpDate.Value = DateTime.Today;
            cmbType.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            txtDescription.Clear();
            nudAmount.Value = 0;
            txtDescription.Focus();
        }
    }
}
