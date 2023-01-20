Console.WriteLine("Enter the number: ");
string? Number = Console.ReadLine();
int a = Int32.Parse(Number);

for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("even number - {0}", i);
    }
}
