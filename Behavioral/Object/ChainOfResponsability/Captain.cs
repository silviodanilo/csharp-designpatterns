namespace ChainOfResponsability
{
    public class Captain : Military
    {
        public Captain(string Name, Military successor): base(LevelCommand.Captain, Name, successor) { }

        public override string ToString()
        {
            return $"Nome: {this.Name}, LevelCommand: {this.LevelCommand}, Successor Name; {Successor?.Name}";
        }
    }
}