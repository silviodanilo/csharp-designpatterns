using Proxy;

ProxyVault proxyVault = new ProxyVault("secretKey");

string key = "secretKey";

bool access = proxyVault.Open( key );
if (access)
{
    System.Console.WriteLine("Access OK");
    proxyVault.Close(key);
}
else
    System.Console.WriteLine("Access deny");

