Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int[] arr2 = new int[n / 2];
for (int i = 0; i < n; i++)
{
    arr[i] = new Random().Next(0, 9);
    for (int j = 0; j < n / 2; j++)
    {
        arr2[j] = arr[i] * arr[arr2.Length - j - 1];
    }
}
foreach (int y in arr)
{
    Console.Write($"{y}, ");
}
Console.Write("\b\b ");
Console.WriteLine(" ");
Console.WriteLine("Подсчет");
foreach (int e in arr2)
{
    Console.Write($"{e}, ");
}
Console.Write("\b\b ");
