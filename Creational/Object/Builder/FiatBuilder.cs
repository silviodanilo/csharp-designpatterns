namespace Builder
{
	public class FiatBuilder : CarBuilder
	{
		public FiatBuilder()
		{
			base.ClassName = "FiatBuilder".ToString();
		}

		protected override Engine BuildEngine()
		{
			return new FiatEngine();
		}

		protected override Wheel BuildWheel()
		{
			return new FiatWheel();
		}

		public override Car BuildCar()
		{
			Car car = new Car();
			car.NameCarBuilder = ToString();
			car.Engine = BuildEngine();
			car.Wheels[0] = BuildWheel();
			car.Wheels[1] = BuildWheel();
			car.Wheels[2] = BuildWheel();
			car.Wheels[3] = BuildWheel();
			return car;
		}

		public override string? ToString()
		{
			return base.ClassName;
		}
	}
}
