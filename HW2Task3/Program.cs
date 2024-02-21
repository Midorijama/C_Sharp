// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Write("Введите двузначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 || a < 10)
{
    Console.WriteLine("Неподходящее число");
}
else
{
    int d1 = a / 10;
    int d2 = a % 10;
    if (d1 > d2)
    {
        Console.WriteLine(d1);
    }
    else
    {
        Console.WriteLine(d2);
    }
}