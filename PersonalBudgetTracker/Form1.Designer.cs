namespace PersonalBudgetTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// True if managed resources should be disposed.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle =
                new System.Windows.Forms.Label();

            this.lblInstructions =
                new System.Windows.Forms.Label();

            this.lblDate =
                new System.Windows.Forms.Label();

            this.dtpDate =
                new System.Windows.Forms.DateTimePicker();

            this.lblType =
                new System.Windows.Forms.Label();

            this.cmbType =
                new System.Windows.Forms.ComboBox();

            this.lblCategory =
                new System.Windows.Forms.Label();

            this.cmbCategory =
                new System.Windows.Forms.ComboBox();

            this.lblDescription =
                new System.Windows.Forms.Label();

            this.txtDescription =
                new System.Windows.Forms.TextBox();

            this.lblAmount =
                new System.Windows.Forms.Label();

            this.nudAmount =
                new System.Windows.Forms.NumericUpDown();

            this.btnAdd =
                new System.Windows.Forms.Button();

            this.lblTransactions =
                new System.Windows.Forms.Label();

            this.btnDelete =
                new System.Windows.Forms.Button();

            this.lblFilterType =
                new System.Windows.Forms.Label();

            this.cmbFilterType =
                new System.Windows.Forms.ComboBox();

            this.lblFilterCategory =
                new System.Windows.Forms.Label();

            this.cmbFilterCategory =
                new System.Windows.Forms.ComboBox();

            this.btnClearFilter =
                new System.Windows.Forms.Button();

            this.dgvTransactions =
                new System.Windows.Forms.DataGridView();

            this.lblTotalIncomeTitle =
                new System.Windows.Forms.Label();

            this.lblTotalIncome =
                new System.Windows.Forms.Label();

            this.lblTotalExpensesTitle =
                new System.Windows.Forms.Label();

            this.lblTotalExpenses =
                new System.Windows.Forms.Label();

            this.lblBalanceTitle =
                new System.Windows.Forms.Label();

            this.lblBalance =
                new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)
                (this.nudAmount)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTransactions)).BeginInit();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    16F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblTitle.Location =
                new System.Drawing.Point(20, 15);

            this.lblTitle.Name =
                "lblTitle";

            this.lblTitle.Size =
                new System.Drawing.Size(253, 30);

            this.lblTitle.TabIndex =
                0;

            this.lblTitle.Text =
                "Personal Budget Tracker";

            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;

            this.lblInstructions.ForeColor =
                System.Drawing.Color.DimGray;

            this.lblInstructions.Location =
                new System.Drawing.Point(23, 50);

            this.lblInstructions.Name =
                "lblInstructions";

            this.lblInstructions.Size =
                new System.Drawing.Size(314, 15);

            this.lblInstructions.TabIndex =
                1;

            this.lblInstructions.Text =
                "Enter the transaction information in the fields below.";

            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;

            this.lblDate.Location =
                new System.Drawing.Point(23, 86);

            this.lblDate.Name =
                "lblDate";

            this.lblDate.Size =
                new System.Drawing.Size(31, 15);

            this.lblDate.TabIndex =
                2;

            this.lblDate.Text =
                "Date";

            // 
            // dtpDate
            // 
            this.dtpDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpDate.Location =
                new System.Drawing.Point(25, 107);

            this.dtpDate.Name =
                "dtpDate";

            this.dtpDate.Size =
                new System.Drawing.Size(125, 23);

            this.dtpDate.TabIndex =
                0;

            // 
            // lblType
            // 
            this.lblType.AutoSize = true;

            this.lblType.Location =
                new System.Drawing.Point(166, 86);

            this.lblType.Name =
                "lblType";

            this.lblType.Size =
                new System.Drawing.Size(31, 15);

            this.lblType.TabIndex =
                4;

            this.lblType.Text =
                "Type";

            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbType.FormattingEnabled =
                true;

            this.cmbType.Location =
                new System.Drawing.Point(169, 107);

            this.cmbType.Name =
                "cmbType";

            this.cmbType.Size =
                new System.Drawing.Size(120, 23);

            this.cmbType.TabIndex =
                1;

            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;

            this.lblCategory.Location =
                new System.Drawing.Point(306, 86);

            this.lblCategory.Name =
                "lblCategory";

            this.lblCategory.Size =
                new System.Drawing.Size(55, 15);

            this.lblCategory.TabIndex =
                6;

            this.lblCategory.Text =
                "Category";

            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbCategory.FormattingEnabled =
                true;

            this.cmbCategory.Location =
                new System.Drawing.Point(309, 107);

            this.cmbCategory.Name =
                "cmbCategory";

            this.cmbCategory.Size =
                new System.Drawing.Size(140, 23);

            this.cmbCategory.TabIndex =
                2;

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;

            this.lblDescription.Location =
                new System.Drawing.Point(466, 86);

            this.lblDescription.Name =
                "lblDescription";

            this.lblDescription.Size =
                new System.Drawing.Size(67, 15);

            this.lblDescription.TabIndex =
                8;

            this.lblDescription.Text =
                "Description";

            // 
            // txtDescription
            // 
            this.txtDescription.Location =
                new System.Drawing.Point(469, 107);

            this.txtDescription.Name =
                "txtDescription";

            this.txtDescription.Size =
                new System.Drawing.Size(190, 23);

            this.txtDescription.TabIndex =
                3;

            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;

            this.lblAmount.Location =
                new System.Drawing.Point(676, 86);

            this.lblAmount.Name =
                "lblAmount";

            this.lblAmount.Size =
                new System.Drawing.Size(51, 15);

            this.lblAmount.TabIndex =
                10;

            this.lblAmount.Text =
                "Amount";

            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces =
                2;

            this.nudAmount.Location =
                new System.Drawing.Point(679, 107);

            this.nudAmount.Maximum =
                new decimal(
                    new int[]
                    {
                        10000000,
                        0,
                        0,
                        0
                    });

            this.nudAmount.Name =
                "nudAmount";

            this.nudAmount.Size =
                new System.Drawing.Size(105, 23);

            this.nudAmount.TabIndex =
                4;

            this.nudAmount.ThousandsSeparator =
                true;

            // 
            // btnAdd
            // 
            this.btnAdd.Location =
                new System.Drawing.Point(803, 104);

            this.btnAdd.Name =
                "btnAdd";

            this.btnAdd.Size =
                new System.Drawing.Size(110, 29);

            this.btnAdd.TabIndex =
                5;

            this.btnAdd.Text =
                "Add Transaction";

            this.btnAdd.UseVisualStyleBackColor =
                true;

            this.btnAdd.Click +=
                new System.EventHandler(
                    this.btnAdd_Click);

            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize =
                true;

            this.lblTransactions.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblTransactions.Location =
                new System.Drawing.Point(21, 165);

            this.lblTransactions.Name =
                "lblTransactions";

            this.lblTransactions.Size =
                new System.Drawing.Size(99, 20);

            this.lblTransactions.TabIndex =
                13;

            this.lblTransactions.Text =
                "Transactions";

            // 
            // btnDelete
            // 
            this.btnDelete.Location =
                new System.Drawing.Point(785, 159);

            this.btnDelete.Name =
                "btnDelete";

            this.btnDelete.Size =
                new System.Drawing.Size(128, 29);

            this.btnDelete.TabIndex =
                6;

            this.btnDelete.Text =
                "Delete Selected";

            this.btnDelete.UseVisualStyleBackColor =
                true;

            this.btnDelete.Click +=
    new System.EventHandler(
        this.btnDelete_Click);

            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;

            this.lblFilterType.Location =
                new System.Drawing.Point(145, 167);

            this.lblFilterType.Name =
                "lblFilterType";

            this.lblFilterType.Size =
                new System.Drawing.Size(43, 15);

            this.lblFilterType.TabIndex =
                22;

            this.lblFilterType.Text =
                "Type:";

            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbFilterType.FormattingEnabled =
                true;

            this.cmbFilterType.Location =
                new System.Drawing.Point(192, 163);

            this.cmbFilterType.Name =
                "cmbFilterType";

            this.cmbFilterType.Size =
                new System.Drawing.Size(115, 23);

            this.cmbFilterType.TabIndex =
                23;

            this.cmbFilterType.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbFilter_SelectedIndexChanged);

            // 
            // lblFilterCategory
            // 
            this.lblFilterCategory.AutoSize = true;

            this.lblFilterCategory.Location =
                new System.Drawing.Point(323, 167);

            this.lblFilterCategory.Name =
                "lblFilterCategory";

            this.lblFilterCategory.Size =
                new System.Drawing.Size(58, 15);

            this.lblFilterCategory.TabIndex =
                24;

            this.lblFilterCategory.Text =
                "Category:";

            // 
            // cmbFilterCategory
            // 
            this.cmbFilterCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbFilterCategory.FormattingEnabled =
                true;

            this.cmbFilterCategory.Location =
                new System.Drawing.Point(386, 163);

            this.cmbFilterCategory.Name =
                "cmbFilterCategory";

            this.cmbFilterCategory.Size =
                new System.Drawing.Size(130, 23);

            this.cmbFilterCategory.TabIndex =
                25;

            this.cmbFilterCategory.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbFilter_SelectedIndexChanged);

            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location =
                new System.Drawing.Point(532, 159);

            this.btnClearFilter.Name =
                "btnClearFilter";

            this.btnClearFilter.Size =
                new System.Drawing.Size(95, 29);

            this.btnClearFilter.TabIndex =
                26;

            this.btnClearFilter.Text =
                "Clear Filters";

            this.btnClearFilter.UseVisualStyleBackColor =
                true;

            this.btnClearFilter.Click +=
                new System.EventHandler(
                    this.btnClearFilter_Click);

            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows =
                false;

            this.dgvTransactions.AllowUserToDeleteRows =
                false;

            this.dgvTransactions.AutoSizeColumnsMode =
                System.Windows.Forms
                    .DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvTransactions.BackgroundColor =
                System.Drawing.SystemColors.AppWorkspace;

            this.dgvTransactions.ColumnHeadersHeightSizeMode =
                System.Windows.Forms
                    .DataGridViewColumnHeadersHeightSizeMode
                    .AutoSize;

            this.dgvTransactions.Location =
                new System.Drawing.Point(25, 197);

            this.dgvTransactions.MultiSelect =
                false;

            this.dgvTransactions.Name =
                "dgvTransactions";

            this.dgvTransactions.ReadOnly =
                true;

            this.dgvTransactions.RowHeadersWidth =
                51;

            this.dgvTransactions.SelectionMode =
                System.Windows.Forms
                    .DataGridViewSelectionMode.FullRowSelect;

            this.dgvTransactions.Size =
                new System.Drawing.Size(888, 290);

            this.dgvTransactions.TabIndex =
                7;

            // 
            // lblTotalIncomeTitle
            // 
            this.lblTotalIncomeTitle.AutoSize =
                true;

            this.lblTotalIncomeTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblTotalIncomeTitle.Location =
                new System.Drawing.Point(26, 515);

            this.lblTotalIncomeTitle.Name =
                "lblTotalIncomeTitle";

            this.lblTotalIncomeTitle.Size =
                new System.Drawing.Size(83, 15);

            this.lblTotalIncomeTitle.TabIndex =
                16;

            this.lblTotalIncomeTitle.Text =
                "TOTAL INCOME";

            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize =
                true;

            this.lblTotalIncome.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblTotalIncome.ForeColor =
                System.Drawing.Color.DarkGreen;

            this.lblTotalIncome.Location =
                new System.Drawing.Point(25, 540);

            this.lblTotalIncome.Name =
                "lblTotalIncome";

            this.lblTotalIncome.Size =
                new System.Drawing.Size(148, 20);

            this.lblTotalIncome.TabIndex =
                17;

            this.lblTotalIncome.Text =
                "Total Income: $0.00";

            // 
            // lblTotalExpensesTitle
            // 
            this.lblTotalExpensesTitle.AutoSize =
                true;

            this.lblTotalExpensesTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblTotalExpensesTitle.Location =
                new System.Drawing.Point(330, 515);

            this.lblTotalExpensesTitle.Name =
                "lblTotalExpensesTitle";

            this.lblTotalExpensesTitle.Size =
                new System.Drawing.Size(97, 15);

            this.lblTotalExpensesTitle.TabIndex =
                18;

            this.lblTotalExpensesTitle.Text =
                "TOTAL EXPENSES";

            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize =
                true;

            this.lblTotalExpenses.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblTotalExpenses.ForeColor =
                System.Drawing.Color.DarkRed;

            this.lblTotalExpenses.Location =
                new System.Drawing.Point(329, 540);

            this.lblTotalExpenses.Name =
                "lblTotalExpenses";

            this.lblTotalExpenses.Size =
                new System.Drawing.Size(166, 20);

            this.lblTotalExpenses.TabIndex =
                19;

            this.lblTotalExpenses.Text =
                "Total Expenses: $0.00";

            // 
            // lblBalanceTitle
            // 
            this.lblBalanceTitle.AutoSize =
                true;

            this.lblBalanceTitle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblBalanceTitle.Location =
                new System.Drawing.Point(665, 515);

            this.lblBalanceTitle.Name =
                "lblBalanceTitle";

            this.lblBalanceTitle.Size =
                new System.Drawing.Size(113, 15);

            this.lblBalanceTitle.TabIndex =
                20;

            this.lblBalanceTitle.Text =
                "CURRENT BALANCE";

            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize =
                true;

            this.lblBalance.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.lblBalance.ForeColor =
                System.Drawing.Color.DarkBlue;

            this.lblBalance.Location =
                new System.Drawing.Point(664, 540);

            this.lblBalance.Name =
                "lblBalance";

            this.lblBalance.Size =
                new System.Drawing.Size(164, 20);

            this.lblBalance.TabIndex =
                21;

            this.lblBalance.Text =
                "Current Balance: $0.00";

            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.SystemColors.Control;

            this.ClientSize =
                new System.Drawing.Size(940, 590);

            this.Controls.Add(
                this.lblBalance);

            this.Controls.Add(
                this.lblBalanceTitle);

            this.Controls.Add(
                this.lblTotalExpenses);

            this.Controls.Add(
                this.lblTotalExpensesTitle);

            this.Controls.Add(
                this.lblTotalIncome);

            this.Controls.Add(
                this.lblTotalIncomeTitle);

            this.Controls.Add(
                this.dgvTransactions);

            this.Controls.Add(
                this.btnDelete);

  
            this.Controls.Add(
                this.btnClearFilter);

            this.Controls.Add(
                this.cmbFilterCategory);

            this.Controls.Add(
                this.lblFilterCategory);

            this.Controls.Add(
                this.cmbFilterType);

            this.Controls.Add(
                this.lblFilterType);

            this.Controls.Add(
                this.lblTransactions);

            this.Controls.Add(
                this.btnAdd);

            this.Controls.Add(
                this.nudAmount);

            this.Controls.Add(
                this.lblAmount);

            this.Controls.Add(
                this.txtDescription);

            this.Controls.Add(
                this.lblDescription);

            this.Controls.Add(
                this.cmbCategory);

            this.Controls.Add(
                this.lblCategory);

            this.Controls.Add(
                this.cmbType);

            this.Controls.Add(
                this.lblType);

            this.Controls.Add(
                this.dtpDate);

            this.Controls.Add(
                this.lblDate);

            this.Controls.Add(
                this.lblInstructions);

            this.Controls.Add(
                this.lblTitle);

            this.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0)));

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox =
                false;

            this.Name =
                "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Personal Budget Tracker";

            ((System.ComponentModel.ISupportInitialize)
                (this.nudAmount)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvTransactions)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblInstructions;

        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.DateTimePicker dtpDate;

        private System.Windows.Forms.Label lblType;

        private System.Windows.Forms.ComboBox cmbType;

        private System.Windows.Forms.Label lblCategory;

        private System.Windows.Forms.ComboBox cmbCategory;

        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.Label lblAmount;

        private System.Windows.Forms.NumericUpDown nudAmount;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label lblTransactions;

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Label lblFilterType;

        private System.Windows.Forms.ComboBox cmbFilterType;

        private System.Windows.Forms.Label lblFilterCategory;

        private System.Windows.Forms.ComboBox cmbFilterCategory;

        private System.Windows.Forms.Button btnClearFilter;

        private System.Windows.Forms.DataGridView dgvTransactions;

        private System.Windows.Forms.Label lblTotalIncomeTitle;

        private System.Windows.Forms.Label lblTotalIncome;

        private System.Windows.Forms.Label lblTotalExpensesTitle;

        private System.Windows.Forms.Label lblTotalExpenses;

        private System.Windows.Forms.Label lblBalanceTitle;

        private System.Windows.Forms.Label lblBalance;
    }
}