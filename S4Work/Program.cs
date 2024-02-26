// int[] FillArrayFromKeyboard(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int[] FillArrayRandomly(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     foreach (var item in arr)
//     {
//         Console.Write($"{item}, ");
//     }
//     Console.Write("\b\b ");
//     Console.WriteLine();
// }

// double TurnArrayIntoNumberStraight(int[] arr)
// {
//     double s = 0;
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         double p = Math.Pow(10, (arr.Length - 1 - i));
//         s = s + arr[i] * p;
//     }
//     int n = arr.Length - 1;
//     s = s + arr[n];
//     return s;
// }

// int CountLD1D7InArray(int[] a)
// {
//     int count = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         int num = Convert.ToInt32(a[i]);
//         while (num > 10)
//         {
//             num %= 10;
//         }
//         if (num == 1 && a[i] % 7 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }

// int FindPrimeInArray(int[] a)
// {
//     int count = 0;
//     int count2 = 0;
//     for (int i = 0; i < a.Length; i++)
//     {
//         int n = 1;
//         while (n <= a[i])
//         {
//             if (a[i] % n == 0)
//                 count = count + 1;
//             n = n + 1;
//         }
//         if (count <= 2)
//             count2 = count2 + 1;
//         count = 0;
//     }
//     return count2;
// }

// Task 1
// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.

// Console.WriteLine("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = FillArrayRandomly(n);
// PrintArray(a);
// int count = FindPrimeInArray(a);
// Console.WriteLine(count);

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

// int[] Random_mas(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(0, 10);
//     }
//     return mas;
// }

// void Print_mas(int[] col)
// {
//     foreach (var item in col)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// bool prost(int num)
// {
//     if (num == 0 || num == 1)
//     {
//         return false;
//     }
//     else
//     {
//         for (int i = 2; i < num; i++)
//         {
//             if (num % i == 0) return false;
//         }
//         return true;
//     }
// }



// int Count(int[] mas)
// {
//     int count = 0;
//     foreach (var item in mas)
//     {
//         if (prost(item))
//         {
//             Console.Write($"{item} ");
//             count++;
//         }
//     }
//     Console.WriteLine();
//     return count;
// }

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] mas = Random_mas(new int[n]);
// Print_mas(mas);

// Console.WriteLine(Count(mas));

// Task 2
// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

// int[] Random_mas(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] = new Random().Next(21, 1000);
//     }
//     return mas;
// }
// void Print_mas(int[] col)
// {
//     foreach (var item in col)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.WriteLine();
// }

// int num_count(int[] mas_2)
// {
//     int n = 0;
//     foreach (var i in mas_2)
//     {
//         if ((i %10 == 1) && (i %7 == 0))
//         {
//             n++;
//         }
//     }
//     return n;
// }


// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] mas = Random_mas(new int[n]);
// Print_mas(mas);
// Console.WriteLine(num_count(mas));


// Task3
// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем. 

int [] ArrayInput (int n)
{
    Console.WriteLine("Введите число от 1 до 9: ");
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray (int [] a)
{
    foreach (var item in a)
    {
        Console.Write($"{item} ");
    }
}

double ArrayToNumber (int [] a)
{
    double s = 0;
    for (int i = 0; i < a.Length; i++)
    {
        double p = Math.Pow(10,a.Length-i-1);
        s = s + a[i]*p;
    }
    return s;
}

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = ArrayInput(n);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArrayToNumber(array));