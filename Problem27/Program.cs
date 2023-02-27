void Main(string[] args)
{
    int n, m; 
    int sum = 0;
    Console.Write("Enter a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    while (n > 0 || n < 0)
    {
        m = n % 10;
        sum = sum + m;
        n = n / 10;
    }
    Console.Write("Sum is = " + sum);
}  
Main(args);

