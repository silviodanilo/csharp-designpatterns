namespace Prototype
{
	public class GM : Car
	{
		public GM()
		{
		}

		public GM(GM gm)
		{
			base.Engine = gm.Engine!.Copy();
			Wheels[0] = gm.Wheels[0].Copy();
			Wheels[1] = gm.Wheels[1].Copy();
			Wheels[2] = gm.Wheels[2].Copy();
			Wheels[3] = gm.Wheels[3].Copy();
		}

		public override Car Clone()
		{
			return new GM(this);
		}
	}
}
