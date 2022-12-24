namespace FactoryMethod
{
	public class FiatEngine : Engine
	{
		public FiatEngine()
		{
			base.ClassName = "FiatEngine".ToString();
		}

		public override string? ToString()
		{
			return base.ClassName;
		}
	}
}
