namespace Builder
{
	public class FiatWheel : Wheel
	{
		public FiatWheel()
		{
			base.ClassName = "FiatWheel".ToString();
		}

		public override string? ToString()
		{
			return base.ClassName;
		}
	}
}
