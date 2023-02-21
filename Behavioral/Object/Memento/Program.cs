using Memento;

Originator originator = new Originator(10, 20, "Red");
Caretaker caretaker = new Caretaker( originator );

System.Console.WriteLine(originator);
caretaker.Move();
System.Console.WriteLine(originator);
caretaker.Move();
System.Console.WriteLine(originator);
caretaker.Undo();
System.Console.WriteLine(originator);
caretaker.Undo();
System.Console.WriteLine(originator);

