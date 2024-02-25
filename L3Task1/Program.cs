double CountResult(int a, int b, int c, int d)
{
    double result = (double)a*b/(c+d);
    return result;
}
Console.WriteLine("Введите первное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первное число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первное число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первное число: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round(CountResult(a,b,c,d), 2));