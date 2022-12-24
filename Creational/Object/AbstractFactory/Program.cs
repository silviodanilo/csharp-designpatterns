
using AbstractFactory;

Console.WriteLine("Testing the AbstractFactory Design Pattern");
Car car = MyCarFactory.CreateCar(new GMFactory());
Console.WriteLine(car.NameCarFactory);
Console.WriteLine(car.Engine);
Console.WriteLine(car.Wheels[0]);

