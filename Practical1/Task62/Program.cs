Console.WriteLine("==== Spiral Matrix ====\n");

int[,] array = new int[4, 4];

array = GeneratingSpiralArray(array);
DisplayMatrix(array);

int[, ] GeneratingSpiralArray(int[, ] array)
{
    int i = 0, j = 0;
    int count = 1;
    int direction = 1;
    bool correct = true;

    while (correct)
    {
        switch (direction)
        {
            case (0):
            {
                if (array[i, j + 1] != 0 && array[i + 1, j] != 0)
                {
                    array[i, j] = count;
                    correct = !correct;
                }
                else
                {
                    array[i, j] = count;
                    count++;
                    j++;
                    direction = 1;
                }
                break;
            }
            case (1):
            {
                if (j < array.GetLength(1) - 1 && array[i, j + 1] == 0)
                {
                    array[i, j] = count;
                    count++;
                    j++;
                }
                else
                {
                    array[i, j] = count;
                    direction = 2;
                }
                break;
            }
            case (2):
            {
                if (i < array.GetLength(0) - 1 && array[i + 1, j] == 0)
                {
                    array[i, j] = count;
                    count++;
                    i++;
                }
                else
                {
                    array[i, j] = count;
                    direction = 3;
                }
                break;
            }
            case (3):
            {
                if (j > 0 && array[i, j - 1] == 0)
                {
                    array[i, j] = count;
                    count++;
                    j--;
                }
                else
                {
                    array[i, j] = count;
                    direction = 4;
                }
                break;
            }
            case (4):
            {
                if (i > 0 && array[i - 1, j] == 0)
                {
                    array[i, j] = count;
                    count++;
                    i--;
                }
                else
                {
                    array[i, j] = count;
                    direction = 0;
                }
                break;
            }
        }
    }

    return array;
}

void DisplayMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == (array.GetLength(1) - 1))
                Console.WriteLine(String.Format("{0,5}]", array[i, j]));
            else
                Console.Write(String.Format("{0,5} ", array[i, j]));
        }
    }
}
