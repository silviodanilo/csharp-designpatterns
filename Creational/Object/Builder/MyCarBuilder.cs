namespace Builder
{
	public static class MyCarBuilder
	{
		public static Car BuildCar(CarBuilder carBuilder)
		{
			return carBuilder.BuildCar();
		}
	}
}
