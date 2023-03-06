namespace Strategy;

public class Numbers
{
    readonly private List<int> _numbers = new();

    public Numbers( List<int> numbers)
    {
        this._numbers = numbers;
    }
    public List<int> Sort( ISortType sortType )
    {
        return sortType.Sort( this._numbers);
    }
}