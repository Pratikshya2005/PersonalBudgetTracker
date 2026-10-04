# Personal Budget Tracker – Testing Report

## Test Environment

- Application: Personal Budget Tracker
- Platform: Windows Forms
- Language: C#
- Framework: .NET Framework 4.7.2
- Testing method: Manual functional testing
- Test date: 5 October 2026

## Test Results

| ID | Feature Tested | Test Procedure | Expected Result | Status |
|---|---|---|---|---|
| T01 | Application startup | Build and start the application | The main form opens without errors | Passed |
| T02 | Add income | Add a salary transaction for $3,000 | Transaction appears and total income increases | Passed |
| T03 | Add expense | Add Food, Transport and Bills expenses | Transactions appear and expense total updates | Passed |
| T04 | Balance calculation | Add $3,000 income and $450 expenses | Current balance displays $2,550 | Passed |
| T05 | Edit transaction | Change Transport expense from $80 to $90 | Selected row and totals update correctly | Passed |
| T06 | Delete transaction | Select a transaction and choose Delete | Confirmation appears and transaction is removed | Passed |
| T07 | Type filter | Select Income or Expense from the type filter | Only matching transactions are displayed | Passed |
| T08 | Category filter | Select a transaction category | Only transactions from that category are displayed | Passed |
| T09 | Date-range filter | Filter transactions from 1–5 October | Salary outside the range is excluded and expenses total $460 | Passed |
| T10 | Clear filters | Apply filters and select Clear Filters | All transactions are displayed again | Passed |
| T11 | Expense summary | Open the Expense Summary | Food, Transport and Bills totals are grouped correctly | Passed |
| T12 | Empty description validation | Attempt to add a transaction without a description | A validation warning is displayed | Passed |
| T13 | Zero amount validation | Attempt to add a transaction with an amount of zero | A validation warning is displayed | Passed |
| T14 | Future-date validation | Attempt to use an invalid future date | A validation warning is displayed | Passed |
| T15 | Invalid date range | Select an end date before the start date | A validation warning is displayed | Passed |
| T16 | JSON persistence | Add transactions, close and restart the program | Saved transactions are loaded from JSON | Passed |

## Calculation Verification

The following sample data was used:

- Salary income: $3,000
- Food expense: $120
- Transport expense: $80
- Bills expense: $250

Before editing:

- Total income: $3,000
- Total expenses: $450
- Current balance: $2,550

After changing Transport from $80 to $90:

- Total expenses: $460
- Current balance: $2,540

When the date filter was set from 1 October to 5 October, the salary transaction outside the selected range was excluded:

- Filtered income: $0
- Filtered expenses: $460
- Filtered balance: -$460

## Final Result

All planned manual test cases passed. The application successfully supports transaction creation, editing, deletion, filtering, summary calculations, validation and JSON data persistence.

No critical defects remained during the final test run.