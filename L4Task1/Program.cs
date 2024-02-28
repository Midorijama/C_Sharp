// Создать двумерный массив с размерами 3х5, состоящий из целых чисел.
// Вывести элементы на экран

int[,] FillMatrixArrayFromKeyboard(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"Введите элемент {j + 1} массива из {i} строки: ");
            array[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

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

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = FillMatrixArrayFromKeyboard(n, m);
PrintMatrixArray(array);