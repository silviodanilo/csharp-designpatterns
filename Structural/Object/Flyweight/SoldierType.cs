namespace Flyweight
{
    public class SoldierType
    {
        public string? SkinColor { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public SoldierType( string skinColor, double height, double weight)
        {
            SkinColor = skinColor;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"SkinColor: {SkinColor}, Height: {Height}, Weight: {Weight}";
        }
    }
}