namespace Bridge
{
	public class Car
	{
		private CarImp CarImp { get; set; }

		public Car(CarImp carImp)
		{
			CarImp = carImp;
		}

		public void Move(int CordAX, int CordAY, int CordBX, int CordBY)
		{
			CarImp.Move(CordAX, CordAY, CordBX, CordBY);
		}
	}
}
