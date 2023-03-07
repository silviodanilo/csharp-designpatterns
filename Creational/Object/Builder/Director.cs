namespace Builder
{
    public class Director
    {
        public CarBuilder? CarBuilder { get; set; }

        public Director(CarBuilder carBuilder)
        {
            this.CarBuilder = carBuilder;
        }

        public void Construct()
        {
            CarBuilder?.BuildEngine();
            CarBuilder?.BuildWheel();
        }
    }
}
