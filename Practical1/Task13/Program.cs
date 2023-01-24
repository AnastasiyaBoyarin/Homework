Console.WriteLine("Enter number: ");
int a = Int32.Parse(Console.ReadLine());

string str = a.ToString();
int[] b = new int[str.Length];
for(int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}

if (b.Length >= 3)
{
    Console.WriteLine("The third digit of number: {0}", b[2]);
}
else
{
    Console.WriteLine("You enter not three-digit number");
}