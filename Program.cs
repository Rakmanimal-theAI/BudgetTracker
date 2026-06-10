using BudgetTracker.Models;

List<Transaction> transactions = new List<Transaction>();

while (true)
{
    Console.WriteLine("\n=== Budget Tracker ===");
    Console.WriteLine("1. Add Transaction");
    Console.WriteLine("2. View All Transactions");
    Console.WriteLine("3. View Balance");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("===New Transaction===");
            Console.Write("Add a Transaction Type (Expense/Income):");
            TransactionType type = Enum.Parse<TransactionType>(Console.ReadLine(), ignoreCase: true);
            Console.Write("Add a Transaction Amount:");
            decimal amount;
            try {
                decimal amount = decimal.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Invalid amount, please enter a number.");
                break;
            }
            Console.Write("Add a Transaction Category:");
            string category = Console.ReadLine();
            Console.Write("Add a Transaction Description:");
            string description = Console.ReadLine();

            Transaction transaction = new Transaction {
                Type = type,
                Amount = amount,
                Category = category,
                Description = description,
                Date = DateTime.Now
            };
            transactions.Add(transaction);
            break;
        case "2":
            if (transactions.Count == 0) {
                Console.WriteLine("No transactions yet.");
                break;
            }
            foreach (Transaction t in transactions)
            {   
                Console.WriteLine("===Transaction===");
                Console.WriteLine("Transaction Type:");
                Console.WriteLine(t.Type);
                Console.WriteLine("Transaction Amount:");
                Console.WriteLine(t.Amount);
                Console.WriteLine("Transaction Category:");
                Console.WriteLine(t.Category);
                Console.WriteLine("Transaction Description:");
                Console.WriteLine(t.Description);
                Console.WriteLine("Transaction Date:");
                Console.WriteLine(t.Date);
            }
            break;
        case "3":
            if (transactions.Count == 0) {
                Console.WriteLine("No transactions yet.");
                break;
            }
            decimal balance = 0m;
            foreach (Transaction t in transactions)
            {
                if (t.Type == TransactionType.Income){
                    balance = balance + t.Amount;
                }
                else {
                    balance = balance - t.Amount;
                }
            }

            Console.WriteLine("Balance amount:");
            Console.WriteLine(balance);
            break;
        case "4":
            return;
        default:
            Console.WriteLine("Invalid option, try again.");
            break;
    }
}