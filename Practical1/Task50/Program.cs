Console.WriteLine("Generating two dimensial array:");
Random rnd = new Random();

int m = rnd.Next(1, 10);
int n = rnd.Next(1, 10);

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.WriteLine("[{0}, {1}] = {2}", i, j, array[i,j]);
    }
}

Console.WriteLine("Enter position x and y of elements in two dimensial array:");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (Math.Min(array.GetLength(0) - 1, Math.Abs(x)) == x 
                && Math.Min(array.GetLength(1) - 1, Math.Abs(y)) == y)
{
    Console.WriteLine("[{0}, {1}] = {2}", x, y, array[x,y]);
}
else
{
    Console.WriteLine("Entered postion does not exist");
}
