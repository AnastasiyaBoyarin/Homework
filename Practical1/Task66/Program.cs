Console.Write("\n\n Recursion : Sum of natural numbers from M to N:\n");
Console.Write("--------------------------------------------------------\n");

int m = EnterNumber("M");
int n = EnterNumber("N");

Console.Write(" The sum of natural numbers is from {0} to {1}: {2}\n\n", m, n , PrintSumOfNumbers(m, n));

int EnterNumber(string number)
{
    Console.Write(" Enter number {0}: ", number);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int PrintSumOfNumbers(int m, int n)
{
    if (m == n)
	{
	    return m;
	}

	return n + PrintSumOfNumbers(m, n - 1);
}