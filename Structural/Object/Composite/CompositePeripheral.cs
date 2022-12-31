namespace Composite
{
    public class CompositePeripheral : Peripheral
    {
        protected List<Peripheral> _peripherals = new();

        public override void Add(Peripheral peripheral)
        {
            _peripherals?.Add(peripheral);
        }

        public override void Remove(Peripheral peripheral)
        {
            _peripherals?.Remove(peripheral);
        }

        public override decimal TotalPrice()
        {
            decimal sum = 0;

            foreach( Peripheral p in _peripherals!)
            {
                sum += p.TotalPrice();
            }

            return sum;
        }
        
    }
}