namespace Builder
{
	public abstract class CarBuilder
	{
		protected Car? Car = new Car();

        public abstract void BuildEngine();

		public abstract void BuildWheel();

		public abstract Car BuildCar();
	}
}
