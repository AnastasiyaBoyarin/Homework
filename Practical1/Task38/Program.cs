Console.WriteLine("Displaying of array:");

int[] array = new int[5];
Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(0, 1000);
}

DisplayDiffBeetweenMinMaxNumbers(array);

void DisplayDiffBeetweenMinMaxNumbers(int[] array)
{
    int min = array[0];
    int max = array[0];
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] > max)
        {
            max = array[i];    
        }

        if (array[i] < min)
        {
            min = array[i];
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
    diff = max - min;
    Console.Write(" -> {0}", diff);
}