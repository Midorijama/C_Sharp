// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 

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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr [i, j]}, ");
        }
        Console.Write("\b\b ");
        Console.WriteLine();
    }
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

int [] CreateArrayFromAveragesOfLinesOfMatrix (int [,] array, int n, int m)
{
    int [] newarray = new int [n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int s = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            s = s+array[i,j];
        }
        newarray [i] = s/m;
    }
    return newarray;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = FillMatrixArrayFromKeyboard(n, m);
PrintMatrixArray(array);
int [] newarray = CreateArrayFromAveragesOfLinesOfMatrix(array,n,m);
PrintArray(newarray);
