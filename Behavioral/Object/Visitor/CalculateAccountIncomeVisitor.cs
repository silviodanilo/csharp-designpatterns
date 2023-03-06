namespace Visitor
{
    public class CalculateAccountIncomeVisitor : IAccountVisitor
    {
        public void VisitSavingsAccount(SavingsAccount savingsAccount)
        {
            savingsAccount.Balance += (savingsAccount.Balance * savingsAccount.Income);

        }
        public void VisitCurrentAccount(CurrentAccount currentAccount)
        {
            currentAccount.Balance += ( currentAccount.Balance * currentAccount.Income);
        }
    }
}