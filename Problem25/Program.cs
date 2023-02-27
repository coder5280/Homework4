int Pow(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

//int numberA = 3;
//int numberB = 5;
Console.Write("Enter A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int res = Pow(numberA, numberB);
Console.WriteLine("Answer " + res);
