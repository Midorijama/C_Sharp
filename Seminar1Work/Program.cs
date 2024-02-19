//Task 1
// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == Math.Pow(b,2))
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

//Task 2
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = -n;
while(i <= n)
{
    Console.Write(i);
    Console.Write(" ");
    i = i + 1;
}