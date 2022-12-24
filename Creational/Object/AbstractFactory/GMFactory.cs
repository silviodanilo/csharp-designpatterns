namespace AbstractFactory
{
	public class GMFactory : CarFactory
	{
		public GMFactory()
		{
			base.ClassName = "GMFactory".ToString();
		}

		public override Engine CreateEngine()
		{
			return new GMEngine();
		}

		public override Wheel CreateWheel()
		{
			return new GMWheel();
		}

		public override string? ToString()
		{
			return base.ClassName;
		}
	}
}
