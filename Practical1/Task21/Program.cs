Console.WriteLine("Enter X coordinate of object A in 3D position:");
int xA = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Y coordinate of object A in 3D position:");
int yA = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Z coordinate of object A in 3D position:");
int zA = Int32.Parse(Console.ReadLine());

Console.WriteLine("==============================================");

Console.WriteLine("Enter X coordinate of object B in 3D position:");
int xB = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Y coordinate of object B in 3D position:");
int yB = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter Z coordinate of object B in 3D position:");
int zB = Int32.Parse(Console.ReadLine());

double l = Math.Sqrt((xA-xB)*(xA-xB) + (yA-yB)*(yA-yB) + (zA-zB)*(zA-zB));

Console.WriteLine("A ({0},{1},{2}); B ({3},{4},{5}) -> {6}", xA, yA, zA, xB, yB, zB, l);

