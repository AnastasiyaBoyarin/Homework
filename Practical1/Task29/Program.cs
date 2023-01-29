Console.WriteLine("Displaying of array which consists of 8 elements:");

int[] array = new int[8];
Random randNum = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(0, 100);
}

DisplayNumbers(array);
DisplayArray(array);

void DisplayNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    { 
        if (i == array.Length - 1)
        {
            Console.Write("{0}", array[i]);
        }
        else
        {
            Console.Write("{0}, ", array[i]);
        }
    }
    Console.Write(" -> ");
}

void DisplayArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    { 
        if (i == array.Length - 1)
        {
            Console.Write("{0}", array[i]);
        }
        else
        {
            Console.Write("{0}, ", array[i]);
        }
    }
    Console.Write("]");
}