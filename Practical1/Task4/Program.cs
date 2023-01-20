Console.WriteLine("Enter the first number: ");
string? firstNumber = Console.ReadLine();
int a = Int32.Parse(firstNumber);

Console.WriteLine("Enter the second number: ");
string? secondNumber = Console.ReadLine();
int b = Int32.Parse(secondNumber);

Console.WriteLine("Enter the third number: ");
string? thirdNumber = Console.ReadLine();
int c = Int32.Parse(thirdNumber);

int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(max);