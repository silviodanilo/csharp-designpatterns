using System;

namespace Bridge
{
	public class GMCarImp : CarImp
	{
		public GMCarImp()
		{
			base.BrandName = "GM";
		}

		public override void Move(int CordAX, int CordAY, int CordBX, int CordBY)
		{
			Console.WriteLine($"BrandName = {BrandName}, Car moved from ({CordAX},{CordAY}) to ({CordBX},{CordBY})");
		}
	}
}
