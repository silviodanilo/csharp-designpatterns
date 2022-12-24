namespace Builder
{
	public class GMEngine : Engine
	{
		public GMEngine()
		{
			base.ClassName = "GMEngine".ToString();
		}

		public override string? ToString()
		{
			return base.ClassName;
		}
	}
}
