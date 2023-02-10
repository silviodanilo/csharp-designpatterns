namespace Iterator
{
    public class ListItemIterator : Iterator<Item>
    {
        private int _current;
        private List<Item> ListItem = new();

        public ListItemIterator(List<Item> listItem)
        {
            ListItem = listItem;
            _current = 0;
        }

        public override void First()
        {
            _current = 0;
        }
        public override bool IsDone()
        {
            return _current >= ListItem.Count();
        }
        public override Item CurrentItem()
        {
            if (IsDone())
                throw new IndexOutOfRangeException();
            else
                return ListItem[_current];
        }

        public override void Next()
        {
            _current++;
        }
    }
}