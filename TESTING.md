# Personal Budget Tracker – Manual Testing

This document records the manual tests used to check the main functions of the Personal Budget Tracker. Run each test in Visual Studio and enter `Pass` or `Fail` in the final column.

| ID | Test | Steps / Input | Expected Result | Status |
|---|---|---|---|---|
| T01 | Application startup | Build the solution and press F5 | The form opens without an exception | ___ |
| T02 | Add income | Add Salary income with a valid description and amount | Transaction appears and total income increases | ___ |
| T03 | Add expense | Add a Food expense with a valid amount | Transaction appears and total expenses increase | ___ |
| T04 | Balance calculation | Add income of 1000 and expense of 250 | Current balance displays 750 | ___ |
| T05 | Empty description | Leave description empty and click Add | A validation warning is displayed | ___ |
| T06 | Zero amount | Enter amount 0 and click Add | A validation warning is displayed | ___ |
| T07 | Future transaction date | Select a date after today and click Add | The future-date warning is displayed | ___ |
| T08 | Edit transaction | Select a row, change description or amount, and click Update Selected | The selected transaction is updated | ___ |
| T09 | Delete transaction | Select a row, click Delete, and confirm | The transaction is removed and totals update | ___ |
| T10 | Cancel deletion | Click Delete and select No in the confirmation | The selected transaction remains | ___ |
| T11 | Filter by type | Select Expense in the type filter | Only expense transactions are displayed | ___ |
| T12 | Filter by category | Select Food in the category filter | Only Food transactions are displayed | ___ |
| T13 | Combined filters | Select Expense and Transport | Only Transport expenses are displayed | ___ |
| T14 | Clear filters | Click Clear Filter | All transactions are displayed again | ___ |
| T15 | Date-range filter | Enable date filtering and select a valid range | Only transactions inside the range are displayed | ___ |
| T16 | Invalid date range | Select a start date after the end date | An invalid-date-range warning is displayed | ___ |
| T17 | Filtered totals | Apply a filter that hides some transactions | Summary totals match the displayed transactions | ___ |
| T18 | Category summary | Add expenses in multiple categories and click Expense Summary | Correct expense total is shown for each used category | ___ |
| T19 | Income excluded from expense summary | Add income and open Expense Summary | Income is not included in category expense totals | ___ |
| T20 | JSON persistence | Add or update a transaction, close the program, and reopen it | Saved transaction data is restored | ___ |

## Final Regression Check

After completing individual tests, perform this short sequence:

1. Add one income and two expenses.
2. Edit one expense.
3. Filter the table by type, category, and date.
4. Check the displayed totals.
5. View the category expense summary.
6. Delete one transaction.
7. Restart the application and confirm that the remaining data is restored.

## Testing Notes

- Testing environment: Windows 11 and Visual Studio
- Target framework: .NET Framework 4.7.2
- Testing method: Manual functional and regression testing
- Tester: Pratikshya Pokhrel
- Test date: __________________

Any failed test should be recorded with the input used, the error message, and the change made to correct the issue.
