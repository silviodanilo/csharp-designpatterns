namespace TemplateMethod
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle( string name, double radius)
        {
            this.Name = name;
            this.Radius = radius;
        }

        protected override double DoCalculateArea()
        {
            return Math.PI * Math.Pow( this.Radius, 2);
        }
    }
}