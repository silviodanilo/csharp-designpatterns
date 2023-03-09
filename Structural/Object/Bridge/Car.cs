namespace Bridge
{
    public class Car : AbstractCar
	{
		public Car(CarImp carImp)
		{
			CarImp = carImp;
		}
		public override void Move(int CordAX, int CordAY, int CordBX, int CordBY)
		{
			CarImp!.Move(CordAX, CordAY, CordBX, CordBY);
		}
	}
}

