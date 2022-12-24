namespace Builder
{
	public class Car
	{
		public Wheel[] Wheels = new Wheel[4];

		public string? NameCarBuilder { get; set; }

		public Engine? Engine { get; set; }
	}
}
