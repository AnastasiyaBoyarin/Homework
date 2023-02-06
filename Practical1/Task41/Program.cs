Console.WriteLine("Enter count of numbers M:");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
int count = 0;

Console.WriteLine("Enter {0} numbers:", m);
for (int i = 0; i < m; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());

    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Count of numbers > 0 -> {0}", count);