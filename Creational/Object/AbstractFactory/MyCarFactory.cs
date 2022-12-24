namespace AbstractFactory
{
	public static class MyCarFactory
	{
		public static Car CreateCar(CarFactory carFactory)
		{
			Car car = new Car();
			car.NameCarFactory = carFactory.ToString();
			car.Engine = carFactory.CreateEngine();
			car.Wheels[0] = carFactory.CreateWheel();
			car.Wheels[1] = carFactory.CreateWheel();
			car.Wheels[2] = carFactory.CreateWheel();
			car.Wheels[3] = carFactory.CreateWheel();
			return car;
		}
	}
}
