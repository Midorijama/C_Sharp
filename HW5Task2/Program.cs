// Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

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
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = FillMatrixArrayRandomly(n, m);
PrintMatrixArray(array);
int temp = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if(i == 0)
        {            
            temp = array[i,j];
            array[i,j] = array[m-1,j];
            array[m-1,j] = temp;
        }
    }
}
PrintMatrixArray(array);