namespace AbstractFactory
{
	public abstract class CarFactory
	{
		protected string? ClassName { get; set; }

		public abstract Engine CreateEngine();

		public abstract Wheel CreateWheel();
	}
}
