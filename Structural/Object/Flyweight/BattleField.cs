namespace Flyweight
{
    public class BattleField
    {
        public List<Soldier> Soldiers { get; set; } = new();
        private SoldierTypeFactory _soldierTypeFactory;

        public BattleField()
        {
            _soldierTypeFactory = new();
        }
        public void CreateSoldier( int cordX, int cordY, string skinColor, double height, double weight)
        {
            Soldier soldier = new(cordX, cordY, _soldierTypeFactory.GetSoldierType(skinColor, height, weight));
            Soldiers.Add(soldier);
            System.Console.WriteLine("------ New Soldier Created ------");
        }
    }
}