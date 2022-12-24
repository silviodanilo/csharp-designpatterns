namespace Bridge
{
	public abstract class CarImp
	{
		public string BrandName { get; protected set; } = "";


		public abstract void Move(int CordAX, int CordAY, int CordBX, int CordBY);
	}
}
