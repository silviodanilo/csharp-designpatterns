namespace Builder
{
	public abstract class CarBuilder
	{
		protected string? ClassName { get; set; }

		protected abstract Engine BuildEngine();

		protected abstract Wheel BuildWheel();

		public abstract Car BuildCar();
	}
}
