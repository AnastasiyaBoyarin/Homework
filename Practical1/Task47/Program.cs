Console.WriteLine("Enter size of two-dimensional array");

Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

Random rnd = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.WriteLine("[{0}, {1}] = {2}", i, j, array[i,j]);
    }
}