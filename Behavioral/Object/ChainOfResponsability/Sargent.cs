namespace ChainOfResponsability
{
    public class Sargent : Military
    {
        public Sargent(string Name, Military successor): base(LevelCommand.Sargent, Name, successor) { }

        public override string ToString()
        {
            return $"Nome: {this.Name}, LevelCommand: {this.LevelCommand}, Successor Name; {Successor?.Name}";
        }
    }
}