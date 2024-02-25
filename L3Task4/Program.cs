void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}

int[] FillArrayFromKeyboard(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int SummarizeElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int MultiplyElements(int [] arr)
{
    int product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        product = product*arr[i];
    }
    return product;
}

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayFromKeyboard(n);
PrintArray(array);

int sum = SummarizeElements(array);
int product = MultiplyElements(array);
Console.WriteLine(sum);
Console.WriteLine(product);