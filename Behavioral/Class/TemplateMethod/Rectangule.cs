namespace TemplateMethod
{
    public class Rectangule : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangule( string name, double width, double height)
        {
            this.Name = name;
            this.Height = height;
            this.Width = width;
        }

        protected override double DoCalculateArea()
        {
            return this.Width * this.Height;
        }
    }
}