Console.WriteLine("Enter number:");

int number = Convert.ToInt32(Console.ReadLine());

int result = GetSum(number);

Console.WriteLine("{0} -> {1}", number, result);

int GetSum(int number)
{
    int m, sum = 0;
    while (number > 0)      
    {      
        m = number % 10;      
        sum = sum + m;      
        number = number / 10;      
    }
    return sum; 
}
