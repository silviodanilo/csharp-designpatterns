namespace FactoryMethod
{
	public class CarCreateGM : CarCreate
	{
		public override string? BrandName => "GM";

		protected override Engine CreateEngine()
		{
			return new GMEngine();
		}

		protected override Wheel CreateWheel()
		{
			return new GMWheel();
		}
	}
}
