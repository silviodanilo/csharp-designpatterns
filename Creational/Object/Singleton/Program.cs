using Singleton;

Singleton.Singleton singleton1 = Singleton.Singleton.Instance();
Console.WriteLine(singleton1.Id);
Singleton.Singleton singleton2 = Singleton.Singleton.Instance();
singleton2.Id = 2;
Console.WriteLine(singleton1.Id);

