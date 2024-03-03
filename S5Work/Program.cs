// // Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// // и замените эти элементы на их квадраты.
// void PrintArr(int[,] arry)
// {
//   for (int i = 0; i < arry.GetLength(0); i++)
//   {
//     for (int j = 0; j < arry.GetLength(1); j++)
//     {
//       Console.Write($"{arry[i,j]}\t");
//     }
//     Console.WriteLine();
//   }
// }

// int[,] Squartes(int[,] arry)
// {
//   for (int i = 0; i < arry.GetLength(0); i++)
//   {
//     for (int j = 0; j < arry.GetLength(1); j++)
//     {
//       if (i % 2 == 0 && j % 2 == 0)
//       {
//         arry[i,j] = arry[i, j] * arry[i, j];
//       }
//     }
//   }
//   return arry;
// }

// Console.Write("Введите размерность m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите размерность n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m,n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//   for (int j = 0; j < arr.GetLength(1); j++)
//   {
//     arr[i,j] = new Random().Next(1,10);
//   }
// }
// PrintArr(arr);

// int[,] arr_new = Squartes(arr);
// Console.WriteLine();
// PrintArr(arr_new);

// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] InputMatrixArrayFromKeyboard(int n, int m)
// {
//     int[,] arr = new int[n, m];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.WriteLine($"Введите {j} элемент для строки {i}: ");
//             arr[i, j] = Convert.ToInt32(Console.ReadLine());
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// int SummarizeElementsMatrixArray(int[,] arr)
// {
//     int s = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 s = s + arr[i, j];
//             }
//         }
//     }
//     return s;
// }

// Console.WriteLine("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] array = InputMatrixArrayFromKeyboard(n, m);
// PrintArray(array);
// int s = SummarizeElementsMatrixArray(array);
// Console.WriteLine($"Сумма элементов находящихся на главной диагонали равна {s}");

int[,] FillMatrixArrayRandomly(int n, int m)
{
    int[,] array = new int[n,m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 1000);
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
            Console.Write($"{arr [i, j]}\t");
        }
        Console.Write("\b");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] array = FillMatrixArrayRandomly(n, m);
PrintMatrixArray(array);