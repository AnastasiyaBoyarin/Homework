Console.Write("\n\n Recursion : Print the natural numbers from N to 1 :\n");
Console.Write("--------------------------------------------------------\n");
int n = EnterNumber();
PrintNumbers(n, 1);

int EnterNumber()
{
    Console.Write(" Enter number N: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int PrintNumbers(int n, int m)
{
    if (n < 1)
	{
	    return m;
	}

	Console.Write(" {0} ", n);
	n--;
	return PrintNumbers(n, m);
}