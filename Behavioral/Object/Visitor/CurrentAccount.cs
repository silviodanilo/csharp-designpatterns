namespace Visitor
{
    public class CurrentAccount : Account
    {
        public CurrentAccount( decimal balance, decimal income, string name)
        {
            this.Balance = balance;
            this.Income = income;
            this.Name = name;
        }
        public override void Accept(IAccountVisitor accountVisitor)
        {
            accountVisitor.VisitCurrentAccount(this);
        }
    }
}