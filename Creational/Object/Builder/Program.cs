using Builder;

Console.WriteLine("Testing the Builder Design Pattern");
Car car = MyCarBuilder.BuildCar(new FiatBuilder());
Console.WriteLine(car.NameCarBuilder);
Console.WriteLine(car.Engine);
Console.WriteLine(car.Wheels[0]);

