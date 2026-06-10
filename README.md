# Personal Finance Tracker — C# Fintech Console Application

## Executive Summary
A command-line personal finance management tool built in C# that enables users to 
track income and expenses in real time. The app solves the problem of manual expense 
tracking by providing instant balance calculation and categorised transaction history, 
reducing the time to assess personal financial health from minutes to seconds.

## Business Problem
Many individuals lack a simple, lightweight tool to monitor their daily income and 
expenses without relying on complex software or internet connectivity. Without clear 
visibility into spending patterns, users risk overspending and poor financial 
decision-making. This tool provides an offline, instant solution to personal cash 
flow management — a core problem in the retail fintech space.

## Methodology
Built using an object-oriented approach in C#, modelling financial transactions as 
strongly-typed domain objects. This mirrors real-world fintech application design, 
where data integrity and type safety are critical. A console-based UI was chosen to 
focus on core business logic and clean code structure over UI complexity.

## Technical Skills
- **Language:** C# (.NET 10)
- **Concepts:** Object-oriented design, enums, generics (`List<T>`), exception 
  handling, object initialisers
- **Practices:** Separation of concerns (Models vs Program logic), input validation 
  with `try/catch`, strongly-typed parsing (`Enum.Parse`, `decimal.Parse`)
- **Tooling:** .NET CLI, Git, GitHub

## Results & Recommendations
The application successfully allows users to:
- Log income and expense transactions with category and description
- View a full transaction history
- Calculate a real-time running balance

**Recommendation:** Integrating persistent storage (e.g. SQL Server or JSON file) 
would allow users to retain transaction history across sessions, significantly 
increasing the practical value of the tool.

## Next Steps & Limitations
**Limitations:**
- Transaction data is held in memory only — all data is lost when the app closes
- No input validation on Category or Description fields
- No filtering or reporting by category or date range

**Next Steps:**
- Add file or database persistence (JSON or SQL Server)
- Implement category-based spending reports
- Build a monthly budget goal feature with overspend alerts
- Migrate to an ASP.NET Web API to serve data to a frontend
