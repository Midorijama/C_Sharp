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

int[] FillArrayRandomly(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
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

double TurnArrayIntoNumberStraight(int[] arr)
{
    double s = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        double p = Math.Pow(10, (arr.Length - 1 - i));
        s = s + arr[i] * p;
    }
    int n = arr.Length - 1;
    s = s + arr[n];
    return s;
}

int CountLD1D7InArray(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        int num = Convert.ToInt32(a[i]);
        while (num > 10)
        {
            num %= 10;
        }
        if (num == 1 && a[i] % 7 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int FindPrimeInArray(int[] a)
{
    int count = 0;
    int count2 = 0;
    for (int i = 0; i < a.Length; i++)
    {
        int n = 1;
        while (n <= a[i])
        {
            if (a[i] % n == 0)
                count = count + 1;
            n = n + 1;
        }
        if (count <= 2)
            count2 = count2 + 1;
        count = 0;
    }
    return count2;
}

// Task 1
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = FillArrayRandomly(n);
PrintArray(a);
int count = FindPrimeInArray(a);
Console.WriteLine(count);

// Task 2
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

// Console.WriteLine("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = FillArrayFromKeyboard(n);
// PrintArray(a);
// int count = CountLD1D7InArray(a);
// Console.WriteLine(count);

// Task3
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 

// Console.WriteLine("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] a = FillArrayFromKeyboard(n);
// PrintArray(a);
// int number = Convert.ToInt32(TurnArrayIntoNumberStraight(a));
// Console.WriteLine(number);
