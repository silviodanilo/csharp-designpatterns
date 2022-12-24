namespace Builder
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
