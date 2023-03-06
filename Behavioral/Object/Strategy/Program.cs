using Strategy;

List<int> list = new List<int>(Enumerable.Range(1, 100));
Numbers numbers = new Numbers(list);

List<int> listSort;
listSort = numbers.Sort(new Descend());

foreach (int n in listSort)
    System.Console.WriteLine($"Value: {n}");

