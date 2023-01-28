namespace ChainOfResponsability
{
    public class Military
    {
        public readonly LevelCommand LevelCommand;
        public Military? Successor { get; set; }
        public string? Name { get; set; }

        public Military(LevelCommand levelCommand, string name, Military successor)
        {
            this.LevelCommand = levelCommand;
            this.Successor = successor;
            this.Name = name;
        }

        public bool ExecuteOrder(string order, LevelCommand levelCommand)
        {
            if (this.LevelCommand != levelCommand)
            {
                return Successor?.ExecuteOrder(order, levelCommand) ?? false;
            }
            System.Console.WriteLine($"order: {order} Level Command: {levelCommand}");
            return true;
        }
    }
}