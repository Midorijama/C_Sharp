// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца.

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
            array[i, j] = new Random().Next(1, 100);
        }
    }
    return array;
}

int[] FindMinimumInMatrixArrayIndexReturn(int[,] numbers)
{
    int min = numbers[0, 0];
    int[] indexarray = new int[2];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] < min)
            {
                min = numbers[i, j];
                indexarray[0] = i;
                indexarray[1] = j;
            }
        }

    }
    return indexarray;
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}

int[,] RemoveLineAndColumnFromMatrixArrayIntoNewMatrix(int[,] arr, int line, int col)
{
    int[,] newarray = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0, j = 0; i < arr.GetLength(0); i++)
    {
        if (i == line)
            continue;
        for (int n = 0, m = 0; n < arr.GetLength(1); n++)
        {
            if (n == col)
                continue;
            newarray[j, m] = arr[i, n];
            m++;
        }
        j++;
    }
    return newarray;
}


Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = FillMatrixArrayRandomly(n, m);
PrintMatrixArray(array);
int[] indexarray = FindMinimumInMatrixArrayIndexReturn(array);
int line = indexarray[0];
int col = indexarray[1];
int[,] newarray = RemoveLineAndColumnFromMatrixArrayIntoNewMatrix(array, line, col);
PrintMatrixArray(newarray);
