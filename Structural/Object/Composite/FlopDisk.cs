namespace Composite 
{
    public class FlopDisk : Peripheral
    {
        public override void Add(Peripheral peripheral)
        {
            throw new NotImplementedException(); //Follow GOF
        }

        public override void Remove(Peripheral peripheral)
        {
            throw new NotImplementedException(); //Following GOF
        }

        public override decimal TotalPrice()
        {
            return Price;
        }
    }
}