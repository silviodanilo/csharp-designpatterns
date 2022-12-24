namespace AbstractFactory
{
	public class FiatFactory : CarFactory
	{
		public FiatFactory()
		{
			base.ClassName = "FiatFactory".ToString();
		}

		public override Engine CreateEngine()
		{
			return new FiatEngine();
		}

		public override Wheel CreateWheel()
		{
			return new FiatWheel();
		}

		public override string? ToString()
		{
			return base.ClassName;
		}
	}
}
