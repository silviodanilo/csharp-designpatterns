using FactoryMethod;

Console.WriteLine("Testing the Factory Method Design Pattern");
CarCreate carCreate = new CarCreateGM();
Car car = carCreate.CreateCar();
Console.WriteLine("Marca do Carro: " + car.BrandName);