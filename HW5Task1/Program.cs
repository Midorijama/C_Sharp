// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

void PrintMatrixArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}, ");
        }
        Console.Write("\b\b ");
        Console.WriteLine();
    }
}

int[,] FillMatrixArrayRandomly(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки: ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int index2 = Convert.ToInt32(Console.ReadLine());
int[,] array = FillMatrixArrayRandomly(n, m);
PrintMatrixArray(array);
if (index1 > n || index2 > m)
{
    Console.WriteLine("Такого элемента не существует");
}
else
{
    Console.WriteLine(array[index1 - 1, index2 - 1]);
}
