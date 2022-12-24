namespace Prototype
{
	public abstract class Car
	{
		public Wheel[] Wheels = new Wheel[4]
		{
			new Wheel(),
			new Wheel(),
			new Wheel(),
			new Wheel()
		};

		public Engine? Engine { get; set; } = new Engine();


		public abstract Car Clone();
	}
}
