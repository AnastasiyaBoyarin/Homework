Console.WriteLine("Enter two numbers:");

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = GetPow(firstNumber, secondNumber);

Console.WriteLine("{0}, {1} -> {2}", firstNumber, secondNumber, result);

int GetPow(int number, int exponent)
{
    int i = 1;
    int power = 1;
    while (i <= exponent)
    {
        power = power * number;
        i++;
    }
    return power;
}
