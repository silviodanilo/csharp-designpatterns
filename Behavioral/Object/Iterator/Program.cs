using Iterator;

List<Item> listItem = new(){ new Item("Silvio"), new Item("Danilo"), new Item("Oliveira")};

ListItemIterator listItemIterator = new(listItem);

//Iteration

for (listItemIterator.First(); !listItemIterator.IsDone(); listItemIterator.Next())
{
    System.Console.WriteLine( listItemIterator.CurrentItem().Name);
}
