namespace Builder
{
	public class GMBuilder : CarBuilder
	{

		public override void BuildEngine()
		{
            Car!.Engine = new GMEngine();
        }

		public override void BuildWheel()
		{
			Car!.Wheels[0] = new GMWheel();
			Car!.Wheels[1] = new GMWheel();
			Car!.Wheels[2] = new GMWheel();
			Car!.Wheels[3] = new GMWheel();
		}

		public override Car BuildCar()
		{
			Car!.Name = "GM";
			return Car!;
		}

	}
}
