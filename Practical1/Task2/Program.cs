Console.WriteLine("Enter the first number: ");
string? firstNumber = Console.ReadLine();
int a = Int32.Parse(firstNumber);

Console.WriteLine("Enter the second number: ");
string? secondNumber = Console.ReadLine();
int b = Int32.Parse(secondNumber);

int max, min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("{0} - max number, {1} - min number", max, min);