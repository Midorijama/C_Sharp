// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

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

int[] SummarizeOneLineOfMatrixArray(int[,] array)
{
    int s = 0;
    int[] newarray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            s = s + array[i, j];
        }
        newarray[i] = s;
        s = 0;
    }
    return newarray;
}

int FindMinimumInArrayIndexReturn(int[] numbers)
{
    int min = numbers[0];
    int index = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
            index = i;
        }
    }
    return index;
}

void PrintStringFromMatrixArray(int[,] arr, int ind)
{
    Console.WriteLine($"Строка с наименьшей суммой значени {ind + 1}");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            if (j == ind)
            {
                Console.Write($"{arr[j, i]}, ");
            }
        }
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = FillMatrixArrayRandomly(n, m);
PrintMatrixArray(array);
int[] countarray = SummarizeOneLineOfMatrixArray(array);
int index = FindMinimumInArrayIndexReturn(countarray);
PrintStringFromMatrixArray(array, index);