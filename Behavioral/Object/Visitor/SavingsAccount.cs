namespace Visitor
{
    public class SavingsAccount : Account
    {
        public SavingsAccount( decimal balance, decimal income, string name)
        {
            this.Balance = balance;
            this.Income = income;
            this.Name = name;
        }
        public override void Accept(IAccountVisitor accountVisitor)
        {
            accountVisitor.VisitSavingsAccount(this);
        }
    }
}