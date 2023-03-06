namespace TemplateMethod
{
    public abstract class Shape
    {
        public string? Name { get; set; }

        private void Header()
        {
            System.Console.WriteLine($"Class name: {Name}");
        }
        protected abstract double DoCalculateArea(); // Template Method
        public void Area()
        {
            Header();
            System.Console.WriteLine($"Area: {DoCalculateArea():F2}");
        }
    }

}