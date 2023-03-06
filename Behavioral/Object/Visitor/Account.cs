namespace Visitor
{
    public abstract class Account
    {
        public decimal Balance { get; set; }
        public decimal Income { get; set; }
        public string? Name { get; set; }

        public abstract void Accept( IAccountVisitor accountVisitor);
    }
}