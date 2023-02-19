Console.WriteLine("Generating two matrices:");

Console.WriteLine("Matrix A:");
int[,] matrixA = GeneratingArray();

Console.WriteLine("=========================");

Console.WriteLine("Matrix B:");
int[,] matrixB = GeneratingArray();

Console.WriteLine("=========================");

MatrixMultiplication(matrixA, matrixB);

int[,] GeneratingArray()
{
    Random rnd = new Random();

    int[,] resultArray = new int[2, 2];

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
            Console.Write("{0}  ", resultArray[i, j]);
        }
        Console.WriteLine();
    }

    return resultArray;
}

void MatrixMultiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] resultMatrix = new int[2, 2];
    for (int i = 0; i < 2; i++) 
    {
        for (int j = 0; j < 2; j++) 
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < 2; k++) 
            {
                resultMatrix[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    Console.WriteLine("The multiplication of the two matrices is:");
    for (int i = 0; i < 2; i++) 
    {
        for (int j = 0; j < 2; j++) 
        {
            Console.Write("{0}  ", resultMatrix[i, j]);
        }
        Console.WriteLine();
    }
}
