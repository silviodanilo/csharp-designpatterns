namespace Singleton
{
	public class Singleton
	{
		private static Singleton? _instance;

		public int Id { get; set; }

		public Car? Car { get; set; }

		private Singleton()
		{
			Id = 1;
			Car = new Car();
		}

		public static Singleton Instance()
		{
			if (_instance == null)
			{
				_instance = new Singleton();
			}
			return _instance;
		}
	}
}
