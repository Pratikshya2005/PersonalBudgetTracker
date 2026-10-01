# Personal Budget Tracker

Personal Budget Tracker is a Windows Forms desktop application for recording personal income and expenses. It allows the user to add, edit, delete, filter, and review transactions while automatically calculating income, expenses, and the current balance.

## Student Details

- Student: Pratikshya Pokhrel
- Student ID: S2400757
- Unit: ITS203
- Project: Assessment C – Personal Budget Tracker

## Features

- Add income and expense transactions
- Store a date, category, description, and amount for each transaction
- Edit an existing transaction by selecting it from the table
- Delete a selected transaction with confirmation
- Display all transactions in a DataGridView
- Calculate total income, total expenses, and current balance
- Filter transactions by income or expense type
- Filter transactions by category
- Filter transactions between two selected dates
- Recalculate totals using the currently displayed transactions
- Display an expense summary grouped by category
- Validate required fields, transaction dates, and amounts
- Automatically save transactions to a local JSON file
- Automatically reload saved transactions when the program starts

## Technologies Used

- C# 7.3
- .NET Framework 4.7.2
- Windows Forms
- Visual Studio
- JSON serialization using `JavaScriptSerializer`
- Git and GitHub for version control

## Object-Oriented Design

The application uses several object-oriented programming concepts:

- `Transaction` is an abstract base class containing properties shared by every transaction.
- `IncomeTransaction` and `ExpenseTransaction` inherit from `Transaction`.
- Polymorphism is used through the overridden `Type` and `GetBalanceEffect()` members.
- `TransactionManager` is responsible for managing, filtering, updating, deleting, and summarising transactions.
- `JsonStorageService` is responsible for saving and loading transaction data.
- Encapsulation is used by keeping the internal transaction list private and returning a copy through the `Transactions` property.

## Project Structure

```text
PersonalBudgetTracker/
├── Models/
│   ├── Transaction.cs
│   ├── IncomeTransaction.cs
│   ├── ExpenseTransaction.cs
│   └── TransactionManager.cs
├── Services/
│   └── JsonStorageService.cs
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
└── PersonalBudgetTracker.csproj
```

## How to Run

1. Clone or download this repository.
2. Open the solution in Visual Studio.
3. Confirm that the project targets .NET Framework 4.7.2.
4. Select `PersonalBudgetTracker` as the startup project.
5. Build the solution using **Build > Build Solution**.
6. Press **F5** or select **Start** to run the application.

## How to Use

1. Select the transaction date.
2. Select Income or Expense.
3. Select a category.
4. Enter a description and amount.
5. Click **Add Transaction**.
6. Select a row to edit or delete it.
7. Use the type, category, and date controls to filter the table.
8. Click **Expense Summary** to view expenses grouped by category.

## Data Storage

Transactions are stored in a JSON file inside the current user's local application-data directory:

```text
PersonalBudgetTracker/transactions.json
```

The application saves the data after adding, editing, or deleting a transaction. Saved data is loaded when the application starts.

## Testing

The application is tested manually using valid and invalid transactions, filters, editing, deletion, calculations, and application restart tests. The complete checklist is available in [TESTING.md](TESTING.md).

## Current Limitations

- The application is designed for one local user.
- Data is stored locally and is not synchronised online.
- Categories are predefined.
- There is no user account or password protection.
- Reports cannot currently be exported to PDF or Excel.

## Tools and Assistance

- Microsoft Visual Studio was used to design, build, run, and debug the application.
- Git and GitHub were used for source control and documenting development progress.
- Microsoft documentation was consulted for Windows Forms and .NET Framework concepts.
- ChatGPT was used as a development support tool for code suggestions, troubleshooting, documentation structure, and explanations. All suggested code was reviewed, adapted, and tested in the project.

## Repository

[PersonalBudgetTracker on GitHub](https://github.com/Pratikshya2005/PersonalBudgetTracker)

## Author

Pratikshya Pokhrel – S2400757
