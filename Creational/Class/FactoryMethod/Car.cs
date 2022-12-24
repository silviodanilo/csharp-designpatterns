namespace FactoryMethod
{
	public class Car
	{
		public Wheel[] Wheels = new Wheel[4];

		public string? BrandName { get; set; }

		public Engine? Engine { get; set; }
	}
}
