using Builder;

Director director;
Car car;

Console.WriteLine("Testing the Builder Design Pattern");

FiatBuilder fiatBuilder = new FiatBuilder();
director = new(fiatBuilder);
director.Construct();
car = fiatBuilder.BuildCar();
Console.WriteLine(car.Name);

GMBuilder gmBuilder = new GMBuilder();
director = new(gmBuilder);
director.Construct();
car = gmBuilder.BuildCar();
Console.WriteLine(car.Name);

