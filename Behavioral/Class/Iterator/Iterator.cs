namespace Iterator
{
    public abstract class Iterator<T>
    {
        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract T CurrentItem();
    }
}