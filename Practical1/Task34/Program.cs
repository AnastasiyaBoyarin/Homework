Console.WriteLine("Displaying of array:");

int[] array = new int[4];
Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(100, 1000);
}

DisplayEvenNumbers(array);

void DisplayEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] % 2 == 0)
        {
            count++;
        }
        if (i == array.Length - 1)
        {
            Console.Write("{0}", array[i]);
        }
        else
        {
            Console.Write("{0}, ", array[i]);
        }
    }
    Console.Write(" -> {0}", count);
}