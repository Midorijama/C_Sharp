// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.

void CountToN(int n)
{
    if (n == 0)
    {
        return;
    }    
    CountToN(n-1);
    Console.WriteLine(n);
}

Console.WriteLine("Write your number");
int n = Convert.ToInt32(Console.ReadLine());
CountToN(n);