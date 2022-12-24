namespace AbstractFactory
{
	public class GMWheel : Wheel
	{
		public GMWheel()
		{
			base.ClassName = "GMWheel".ToString();
		}

		public override string? ToString()
		{
			return base.ClassName;
		}
	}
}
