namespace Builder
{
	public class FiatBuilder : CarBuilder
	{

		public override void BuildEngine()
		{
            Car!.Engine = new FiatEngine();
        }

		public override void BuildWheel()
		{
            Car!.Wheels[0] = new FiatWheel();
			Car!.Wheels[1] = new FiatWheel();
			Car!.Wheels[2] = new FiatWheel();
			Car!.Wheels[3] = new FiatWheel();
        }

		public override Car BuildCar()
		{
            Car!.Name = "Fiat";
            return Car!;
		}

	}
}
