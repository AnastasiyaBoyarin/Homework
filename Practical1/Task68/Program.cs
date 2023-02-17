Console.Write("\n\n Recursion : Ackerman function:\n");
Console.Write("--------------------------------------------------------\n");

int m = EnterNumber("M");
int n = EnterNumber("N");

Console.Write(" A({0}, {1}) = {2} \n\n", m, n , AckFunction(m, n));

int EnterNumber(string number)
{
    Console.Write(" Enter number {0}: ", number);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int AckFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckFunction(m - 1, AckFunction(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}