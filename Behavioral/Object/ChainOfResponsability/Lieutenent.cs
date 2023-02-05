namespace ChainOfResponsability
{
    public class Lieutenent : Military
    {
        public Lieutenent(string Name, Military successor): base(CommandLevel.Lieutenent, Name, successor) { }

        public override string ToString()
        {
            return $"Nome: {this.Name}, CommandLevel: {this.CommandLevel}, Successor Name; {Successor?.Name}";
        }
    }
}