namespace Strategy;

public class Ascend : ISortType
{
    public List<int> Sort( List<int> numbers )
    {
        return numbers.Order().ToList();
    }
}