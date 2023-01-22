namespace Proxy
{
    public class ProxyVault
    {
        private string? Key { get; set; }
        private Vault? Vault { get; set; }

        public ProxyVault( string key)
        {
            Key = key;
            Vault = new Vault();
        }

        public bool Open(string key)
        {
            if (VerifyKey(key))
            {
                Vault?.Open();
                return true;
            }
            return false;
        }
        public bool Close(string key)
        {
            if (VerifyKey(key))
            {
                Vault?.Close();
                return true;
            }
            return false;
        }
        private bool VerifyKey(string key) => (key == this.Key);
    }
}