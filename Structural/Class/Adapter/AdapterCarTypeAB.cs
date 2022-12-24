using System;

namespace Adapter
{
	public class AdapterCarTypeAB : CarTypeA
	{
		public CarTypeB? CarTypeB { get; set; }

		public override void Move(int cordAx, int cordAy, int cordBx, int cordBy)
		{
			Point point = new Point(cordAx, cordAy);
			Point point2 = new Point(cordBx, cordBy);
			CarTypeB?.Move(point, point2);
			Console.WriteLine($"Car moved from {point} to {point2}");
		}
	}
}
