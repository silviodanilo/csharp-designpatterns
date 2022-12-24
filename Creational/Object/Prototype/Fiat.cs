namespace Prototype
{
	public class Fiat : Car
	{
		public Fiat()
		{
		}

		public Fiat(Fiat fiat)
		{
			base.Engine = fiat.Engine!.Copy();
			Wheels[0] = fiat.Wheels[0].Copy();
			Wheels[1] = fiat.Wheels[1].Copy();
			Wheels[2] = fiat.Wheels[2].Copy();
			Wheels[3] = fiat.Wheels[3].Copy();
		}

		public override Car Clone()
		{
			return new Fiat(this);
		}
	}
}
