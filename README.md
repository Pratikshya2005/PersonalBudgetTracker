# Personal Budget Tracker

## Project Description

Personal Budget Tracker is a C# Windows Forms application that helps users record and manage personal income and expenses.

The application allows the user to add transactions, assign categories, view transactions, filter recorded data, and view total income, expenses, and current balance.

## Current Features

- Add income and expense transactions
- Record transaction date, category, description, and amount
- Display transactions in a DataGridView
- Delete selected transactions
- Calculate total income
- Calculate total expenses
- Calculate the current balance
- Filter transactions by type
- Filter transactions by category
- Save transactions to a local JSON file
- Load saved transactions when the application starts
- Validate user input and display error messages

## Object-Oriented Design

The application currently uses:

- An abstract `Transaction` base class
- `IncomeTransaction` and `ExpenseTransaction` subclasses
- Overridden balance calculation methods
- A `TransactionManager` class to manage transactions
- A `JsonStorageService` class to save and load data
- Encapsulation through properties and private collections
- Exception handling for invalid input and storage errors

## Technologies

- C#
- Windows Forms
- .NET Framework 4.7.2
- JSON file storage
- Git and GitHub

## Running the Application

1. Open the solution in Microsoft Visual Studio.
2. Build the solution.
3. Press F5 or select Start.
4. Add a transaction using the fields at the top of the form.

## Development Status

This repository currently represents the Milestone 2 development checkpoint. Additional testing, date filtering, editing functionality, and interface improvements are planned for Milestone 3.

## References and Tools Used

- Microsoft Learn documentation
- Visual Studio documentation
- ChatGPT for debugging assistance, code explanations, and implementation guidance

All generated suggestions were reviewed and tested during development.