int[] FillArrayRandomly(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
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

int FindAmountOfEvensInArray(int[] arr)
{
    int c = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            c = c + 1;
    }
    return c;
}


Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = FillArrayRandomly(n);
PrintArray(a);
int count = FindAmountOfEvensInArray(a);
Console.WriteLine(count);
