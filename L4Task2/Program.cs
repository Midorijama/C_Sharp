// Создать двумерный массив, состоящий из целых чисел. 
// Вывести на экран числа с четной суммой цифер.

void PrintMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            Console.Write($"{arr [i, j]}, ");
        }
        Console.Write("\b\b ");
        Console.WriteLine();
    }
}

int[,] FillMatrixArrayRandomly(int n, int m)
{
    int[,] array = new int[n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random().Next(1, 1000);
        }
    }
    return array;
}

bool CheckForEvenDigitsSum(int n)
{
    int s = 0;
    while (n > 0)
    {
        s = s + (n % 10);
        n = n / 10;
    }
    if (s % 2 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = FillMatrixArrayRandomly(n, m);
PrintMatrixArray(array);
foreach (var item in array)
{
    if(CheckForEvenDigitsSum(item))
    {
        Console.Write($"{item}, ");
    }
}
Console.Write("\b\b ");
Console.WriteLine();