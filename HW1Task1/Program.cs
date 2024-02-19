Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber == secondNumber)
{
    Console.WriteLine("числа равны");
}
else   
    if(firstNumber > secondNumber)
    {
        Console.WriteLine("первое число больше");
    }
    else
    {
        Console.WriteLine("второе число больше");
    }