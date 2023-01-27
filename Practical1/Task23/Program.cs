Console.WriteLine("Enter number N:");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write("Number is : {0} and cube of the {1} is : {2} \n", i, i,(i*i*i));
}
