Console.WriteLine("Enter five digit number");
int a = Int32.Parse(Console.ReadLine());

int reverse = 0;
int n = a;

if (a.ToString().Length != 5)
{
    Console.WriteLine("You enter not five digit number. Could you please try again");
    return;
}

while (n > 0)
{
    int r = n % 10;
    reverse = reverse * 10 + r;
    n = n / 10;
}

if (a == reverse)
{
    Console.WriteLine("Entered five digit number is palidrom");
}
else
{
    Console.WriteLine("Entered five digit number is not palidrom");
}
