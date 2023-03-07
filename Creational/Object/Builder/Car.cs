namespace Builder
{
	public class Car
	{
		public string? Name { get; set; }
        public Wheel[] Wheels = new Wheel[4];
		public Engine? Engine { get; set; }
	}
}
