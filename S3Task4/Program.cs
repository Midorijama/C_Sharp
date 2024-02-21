Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[3];
int d = 1;
if (a < 100 && a > 999)
{
    Console.WriteLine("Число не трехзначное");
}
else
{
    for (int i = 0; i < 3; i++)
    {
        int n = a/d%10;
        arr[i] = n;
        d = d*10; 
    }
}
foreach (int e in arr)
{
    Console.Write($"{e}, ");
}
Console.Write("\b\b  ");