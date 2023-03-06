using Visitor;

SavingsAccount savingsAccount = new( 100.00m, 0.05m, "SavingsAccount");
CurrentAccount currentAccount = new( 100.00m, 0.03m, "CurrentAccount");
CalculateAccountIncomeVisitor calculateAccountIncomeVisitor = new(); //Visitor to calculate income

System.Console.WriteLine($"Savings Account Balance : {savingsAccount.Balance:F2}");
savingsAccount.Accept( calculateAccountIncomeVisitor );
System.Console.WriteLine($"Savings Account Balance : {savingsAccount.Balance:F2}");

System.Console.WriteLine($"Current Account Balance : {currentAccount.Balance:F2}");
currentAccount.Accept( calculateAccountIncomeVisitor );
System.Console.WriteLine($"Current Account Balance : {currentAccount.Balance:F2}");

