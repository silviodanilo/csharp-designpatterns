using System;

namespace Proxy
{
    public class Vault
    {
        public void Open()
        {
            System.Console.WriteLine("----- Vault Opened ----- ");
        }
        public void Close()
        {
            System.Console.WriteLine("----- Vault Closed ----- ");
        }
    }
}