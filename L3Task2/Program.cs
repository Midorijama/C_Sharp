void PrintSquare(int n)
{
    int i = 1;
    while (i<n)
    {
        Console.Write($"{i*i} ");
        i = i + 1;
    }
}
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
PrintSquare(n);