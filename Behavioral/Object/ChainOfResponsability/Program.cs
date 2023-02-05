using ChainOfResponsability;

Sargent sgt = new Sargent("Silvio", null!);
Lieutenent ltn = new Lieutenent("Danilo", sgt);
Captain cap = new Captain("Oliveira", ltn);

if (cap.ExecuteOrder("Fire!!!", CommandLevel.Sargent))
    System.Console.WriteLine("Order executed!");
else
    System.Console.WriteLine("Order not executed!");



