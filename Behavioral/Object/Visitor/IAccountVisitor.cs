namespace Visitor
{
    public interface IAccountVisitor
    {
        public void VisitSavingsAccount( SavingsAccount savingsAccount);
        public void VisitCurrentAccount( CurrentAccount currentAccount);
    }
}