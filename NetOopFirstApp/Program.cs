using NetOopFirstApp;

//Rectangle rect = new Rectangle(10, 20, 30, 40);

//Shape shape;

//shape = new Rectangle(10, 20, 4, 6);
//shape = new Circle(5, 5, 10);

////rect = (Rectangle)new Shape(50, 50);

//object obj = new Rectangle();

//((Circle)shape).Radius = 100;
//(shape as Circle).Radius = 200;

//if(obj is Circle)
//    Console.WriteLine("obj is Rectangle");
//else
//    Console.WriteLine("obj not is Rectangle");


Shape shape; // = new Shape( 1, 2);
//shape.Print();
//Console.WriteLine($"\nSqare = {shape.Square()}");

//shape = new Rectangle(1, 2, 3, 4);
//shape.Print();
//Console.WriteLine($"Sqare = {shape.Square()}");

//shape = new Circle(1, 2, 3);
//shape.Print();
//Console.WriteLine($"Sqare = {shape.Square()}");

Employee bob = new() { Name = "Bobby", Age = 27 };
Console.WriteLine(bob);

Employee joe = new() { Name = "Joseph", Age = 33 };
Console.WriteLine(joe);

Console.WriteLine(bob.Equals(joe));

Console.WriteLine($"bob: {bob.GetHashCode()}, joe: {joe.GetHashCode()}");

Console.WriteLine($"{bob.GetType().Equals(joe.GetType())}");

