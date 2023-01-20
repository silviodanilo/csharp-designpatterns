namespace Flyweight
{
    public class Soldier
    {
        public int CordX { get; set; } //intrinsic state
        public int CordY { get; set; } //intrinsic state
        public SoldierType? SoldierType { get; set; } // extrinsic state

        public Soldier( int cordX,int cordY, SoldierType soldierType)
        {
            CordX = cordX;
            CordY = cordY;
            SoldierType = soldierType;
        }

        public override string ToString()
        {
            return $"Soldier: CordX: {CordX}, CordY: {CordY}, SoldierType: {SoldierType}";
        }
    }
}