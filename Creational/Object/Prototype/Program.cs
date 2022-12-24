using Prototype;

Fiat fiat = new Fiat();
Fiat fiat2 = (Fiat)fiat.Clone();
Console.WriteLine(fiat.Engine);
Console.WriteLine(fiat2.Engine);
