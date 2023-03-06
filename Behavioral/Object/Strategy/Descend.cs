namespace Strategy;

public class Descend : ISortType
{
    public List<int> Sort( List<int> numbers )
    {
        return numbers.OrderDescending().ToList();
    }
}