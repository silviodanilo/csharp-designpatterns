namespace ChainOfResponsability
{
    public class Captain : Military
    {
        public Captain(string Name, Military successor): base(CommandLevel.Captain, Name, successor) { }

        public override string ToString()
        {
            return $"Nome: {this.Name}, CommandLevel: {this.CommandLevel}, Successor Name; {Successor?.Name}";
        }
    }
}