Console.WriteLine("Enter three-digit number: ");
int a = Int32.Parse(Console.ReadLine());

string str = a.ToString();
int[] b = new int[str.Length];
for(int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}

Console.WriteLine("{0} -> {1}", a, b[1]);