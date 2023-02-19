Console.WriteLine("Generating two dimensial array:");

int[,] array = GeneratingArray();

Console.WriteLine("Display number of row with minimum sum of values:");
FindRowWithMinValueOfSumRows(array);

int[,] GeneratingArray()
{
    Random rnd = new Random();

    int[,] resultArray = new int[4, 4];

    for (int i = 0; i < 4; i++)
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

void FindRowWithMinValueOfSumRows(int[,] array)
{
    List<int> rowValues = new List<int>();
    List<int> sumRowValues = new List<int>();

    for (int i = 0; i < 4; i++)
    {
        int sumRows = 0;
        for (int j = 0; j < 4; j++)
        {
            rowValues.Add(array[i, j]);
        }

        foreach (int rowValue in rowValues)
        {
            sumRows = sumRows + rowValue;
        }
        sumRowValues.Add(sumRows);
    }

    Console.WriteLine("{0}", sumRowValues.IndexOf(sumRowValues.Min()) + 1);
}