using Composite;

FlopDisk fd1 = new FlopDisk() { Price = 25.5M };
FlopDisk fd2 = new FlopDisk() { Price = 15.5M };

Peripheral mb = new MotherBoard();
mb.Add(fd1);
mb.Add(fd2);

System.Console.WriteLine($"Total price: {mb.TotalPrice():C}");

