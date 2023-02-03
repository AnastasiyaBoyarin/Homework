Console.WriteLine("Displaying of array:");

int[] array = new int[4];
Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(0, 1000);
}

DisplaySumOfOddNumbers(array);

void DisplaySumOfOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (i % 2 == 1)
        {
            sum = sum + array[i];
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
    Console.Write(" -> {0}", sum);
}