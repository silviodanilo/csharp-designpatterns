using System.Runtime.CompilerServices;

namespace Adapter
{
	public class Point
	{
		public int CordX { get; set; }

		public int CordY { get; set; }

		public Point(int cordX, int cordY)
		{
			CordX = cordX;
			CordY = cordY;
		}

		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Point( ");
			defaultInterpolatedStringHandler.AppendFormatted(CordX);
			defaultInterpolatedStringHandler.AppendLiteral(" , ");
			defaultInterpolatedStringHandler.AppendFormatted(CordY);
			defaultInterpolatedStringHandler.AppendLiteral(" )");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}
}
