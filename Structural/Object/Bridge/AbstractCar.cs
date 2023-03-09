namespace Bridge
{
	public abstract class AbstractCar
	{
		protected CarImp? CarImp { get; set; }

        public abstract void Move(int CordAX, int CordAY, int CordBX, int CordBY);

    }
}

