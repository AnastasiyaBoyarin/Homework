Console.WriteLine("Generating three dimensial array:");

int[,,] array = GeneratingArray();

int[,,] GeneratingArray()
{
    Random rnd = new Random();

    int[,,] resultArray = new int[2, 2, 2];

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                resultArray[i, j, k] = rnd.Next(10, 100);
                Console.Write("{3} ({0},{1},{2}) ", i, j, k, resultArray[i, j, k]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    return resultArray;
}