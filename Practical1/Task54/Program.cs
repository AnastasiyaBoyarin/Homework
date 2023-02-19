Console.WriteLine("Generating two dimensial array:");

int[,] array = GeneratingArray();

Console.WriteLine("Sorted rows by desceding of two dimensial array:");
SortRowsOfArrayByDesc(array);

int[,] GeneratingArray()
{
    Random rnd = new Random();

    int[,] resultArray = new int[3, 4];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
            Console.Write("{0}  ", resultArray[i, j]);
        }
        Console.WriteLine();
    }

    return resultArray;
}

void SortRowsOfArrayByDesc(int[,] array)
{
    List<int> rowValues = new List<int>();
    List<int> sortedRowValues = new List<int>();

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            rowValues.Add(array[i, j]);
        }
        sortedRowValues = rowValues.OrderByDescending(x => x).ToList();

        for (int k = 0; k < 4; k++)
        {
            Console.Write("{0}  ", sortedRowValues[k]);
        }
        Console.WriteLine();
    }
}