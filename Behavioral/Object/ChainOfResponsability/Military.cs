namespace ChainOfResponsability
{
    public class Military
    {
        public readonly CommandLevel CommandLevel;
        public Military? Successor { get; set; }
        public string? Name { get; set; }

        public Military(CommandLevel commandLevel, string name, Military successor)
        {
            this.CommandLevel = commandLevel;
            this.Successor = successor;
            this.Name = name;
        }

        public bool ExecuteOrder(string order, CommandLevel commandLevel)
        {
            if (this.CommandLevel != commandLevel)
            {
                return Successor?.ExecuteOrder(order, commandLevel) ?? false;
            }
            System.Console.WriteLine($"order: {order} CommandLevel: {commandLevel}");
            return true;
        }
    }
}