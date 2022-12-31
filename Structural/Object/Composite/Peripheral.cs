namespace Composite
{
    public abstract class Peripheral
    {
        public decimal Price { protected get; set; }

        public abstract void Add(Peripheral peripheral);
        public abstract void Remove(Peripheral peripheral);
        public abstract decimal TotalPrice();
    }
}