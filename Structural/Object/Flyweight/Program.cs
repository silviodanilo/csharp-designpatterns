using Flyweight;

BattleField battleField = new BattleField();
battleField.CreateSoldier(10, 20, "Black", 1.80, 80);
battleField.CreateSoldier(10, 20, "Black", 2.00, 90);
battleField.CreateSoldier(10, 20, "Black", 1.80, 80);

foreach( Soldier s in battleField.Soldiers)
{
    System.Console.WriteLine(s.ToString());
}
