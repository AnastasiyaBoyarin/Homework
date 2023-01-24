Console.WriteLine("Enter number of day on the week (1-7):");
int a = Int32.Parse(Console.ReadLine());

if (a == 6 || a == 7)
{
    Console.WriteLine("You entered number of day is day off - YES");
}
else
{
    Console.WriteLine("You entered number of day is weekday - NO");
}
