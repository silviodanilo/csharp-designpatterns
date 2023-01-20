using System.Security.Cryptography;
using System.Text;

namespace Flyweight
{
    public class SoldierTypeFactory
    {
        private Dictionary<string, SoldierType> _soldiersTypes = new();
        public SoldierType GetSoldierType( string skinColor, double height, double weight )
        {
            string soldierKey = CreateKey(skinColor, height, weight);
            
            if( _soldiersTypes.TryGetValue(soldierKey, out SoldierType? soldierType))
            {
                return soldierType;
            }
            else
            {
                SoldierType newSoldierType = new SoldierType(skinColor, height, weight);
                _soldiersTypes.Add(soldierKey, newSoldierType );
                return newSoldierType;
            }
        }

        public SoldierTypeFactory()
        {
            //Creating basic soldier
            string soldierKey1 = CreateKey("Black", 1.80, 80);
            string soldierKey2 = CreateKey("White", 1.90, 100);
            string soldierKey3 = CreateKey("Yellow", 1.70, 74);
            _soldiersTypes.Add(soldierKey1, new SoldierType("Black", 1.80, 80) );
            _soldiersTypes.Add(soldierKey2, new SoldierType("White", 1.90, 100) );
            _soldiersTypes.Add(soldierKey3, new SoldierType("Yellow", 1.70, 74) );
        }

        private string CreateKey( string skinColor, double height, double weight )
        {
            string keyStr = skinColor + Convert.ToString(height) + Convert.ToString(weight);
            byte[] dataBytes = Encoding.UTF8.GetBytes(keyStr);
            SHA256 sha = SHA256.Create();
            byte[] hashedData = sha.ComputeHash(dataBytes);
            return Convert.ToBase64String(hashedData);
        }

    }
}