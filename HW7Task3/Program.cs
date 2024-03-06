// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] FillArrayRandomly(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void RecursiveArrayPrint (int [] arr, int index = 0)
{
    if (index == arr.Length)
    { 
    return;
    }
    RecursiveArrayPrint(arr, index + 1);
    Console.Write($"{arr[index]} ");
  
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }    
    Console.WriteLine();
}

Console.WriteLine("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int [] array = FillArrayRandomly(m);
PrintArray(array);
RecursiveArrayPrint(array);


