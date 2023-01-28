namespace ChainOfResponsability
{
    public class Lieutenent : Military
    {
        public Lieutenent(string Name, Military successor): base(LevelCommand.Lieutenent, Name, successor) { }

        public override string ToString()
        {
            return $"Nome: {this.Name}, LevelCommand: {this.LevelCommand}, Successor Name; {Successor?.Name}";
        }
    }
}