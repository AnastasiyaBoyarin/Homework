Console.WriteLine("Intersection of two lines based on y = k1 * x + b1, y = k2 * x + b2:");

Console.WriteLine("Enter b1:");
double b1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter k1:");
double k1 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter b2:");
double b2 = Double.Parse(Console.ReadLine());
Console.WriteLine("Enter k2:");
double k2 = Double.Parse(Console.ReadLine());

Intersection(b1, k1, b2, k2);

//y = k1 * x + b1;
//y = k2 * x + b2;
void Intersection(double b1, double k1, double b2, double k2)
{
    /*
        k1 * x + b1 = k2 * x + b2;
        k1 * x - k2 * x = b2 - b1;
    */
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine("Intersection is -> {0}, {1}", x, y);
}

