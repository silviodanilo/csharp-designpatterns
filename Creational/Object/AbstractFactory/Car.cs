namespace AbstractFactory
{
	public class Car
	{
		public Wheel[] Wheels = new Wheel[4];

		public string? NameCarFactory { get; set; }

		public Engine? Engine { get; set; }
	}
}
