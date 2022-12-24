namespace Builder
{
	public class GMBuilder : CarBuilder
	{
		public GMBuilder()
		{
			base.ClassName = "GMBuilder".ToString();
		}

		protected override Engine BuildEngine()
		{
			return new GMEngine();
		}

		protected override Wheel BuildWheel()
		{
			return new GMWheel();
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
