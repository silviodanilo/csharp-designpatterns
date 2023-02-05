namespace ChainOfResponsability
{
    public class Sargent : Military
    {
        public Sargent(string Name, Military successor): base(CommandLevel.Sargent, Name, successor) { }

        public override string ToString()
        {
            return $"Nome: {this.Name}, CommandLevel: {this.CommandLevel}, Successor Name; {Successor?.Name}";
        }
    }
}