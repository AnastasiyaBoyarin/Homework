Console.WriteLine("Enter the number: ");
string? firstNumber = Console.ReadLine();
int a = Int32.Parse(firstNumber);

if (a % 2 == 0)
{
    Console.WriteLine("a - even number");
}
else
{
    Console.WriteLine("a - odd number");
}