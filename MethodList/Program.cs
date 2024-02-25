﻿// All useful methods with naming

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

int FindAmountOfEvensInArray(int[] arr)
{
    int c = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            c = c + 1;
    }
    return c;
}

void ZeroEvensInArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

int SummarizeElementsInArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int MultiplyElementsInArray(int[] arr)
{
    int product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        product = product * arr[i];
    }
    return product;
}

int GetFindFirstDigitOfNumber(int N)
{
    int d = N;
    while (N > 9)
    {
        N /= 10;
        d = N;
    }
    return d;
}

int RemoveFirstDigitOfNumber(int N)
{
    int p = 1;
    while (N / p > 9)
    {
        p *= 10;
    }
    N = N % p;
    return N;
}

int CountDigits(int N)
{
    int DigitAmount = 1;
    int p = 1;
    while (N / p > 9)
    {
        p = p * 10;
        DigitAmount = DigitAmount + 1;
    }
    return DigitAmount;
}

int FindMinimumInArray(int[] numbers)
{
    int min = numbers[0];
    foreach (int e in numbers)
    {
        if (e < min)
            min = e;
    }
    return min;
}

int FindMaximumInArray(int[] numbers)
{
    int max = numbers[0];
    foreach (int e in numbers)
    {
        if (e > max)
            max = e;
    }
    return max;
}

int FindLastDigit(int n)
{
    while (n > 10)
    {
        n %= 10;
    }
    return n;
}

double TurnArrayIntoNumberStraight(int[] arr)
{
    double s = 0;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        double p = Math.Pow(10, (arr.Length - 1 - i));
        s = s + arr[i]*p;
    } 
    int n = arr.Length-1;
    s = s + arr[n];
    return s;
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