namespace FactoryMethod
{
	public abstract class CarCreate
	{
		public abstract string? BrandName { get; }

		protected abstract Engine CreateEngine();

		protected abstract Wheel CreateWheel();

		public Car CreateCar()
		{
			Car car = new Car();
			car.BrandName = BrandName;
			car.Engine = CreateEngine();
			car.Wheels[0] = CreateWheel();
			car.Wheels[1] = CreateWheel();
			car.Wheels[2] = CreateWheel();
			car.Wheels[3] = CreateWheel();
			return car;
		}
	}
}
