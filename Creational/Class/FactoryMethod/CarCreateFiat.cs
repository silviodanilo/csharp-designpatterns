namespace FactoryMethod
{
	public class CarCreateFiat : CarCreate
	{
		public override string? BrandName => "Fiat";

		protected override Engine CreateEngine()
		{
			return new FiatEngine();
		}

		protected override Wheel CreateWheel()
		{
			return new FiatWheel();
		}
	}
}
