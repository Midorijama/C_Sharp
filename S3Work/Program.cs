// Задание 4 из дз через строку
// Console.WriteLine("Введите число: ");
// string Number = Console.ReadLine()!;
// int n = Convert.ToInt32(Convert.ToString(Number).Length);
// int i = 0;
// while (i < n)
// {
//     Console.Write($"{Number[i]}, ");
//     i = i+1;
// }
// Console.Write("\b\b  ");

// Задайте массив. 
// Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: Да/Нет.

// Console.Write("Введите размерность массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// Рандомное заполнение массива

// for (int i = 0; i < n; i++)
// {
//     arr[i] = new Random().Next(0, 99);
// }

// Вывод всего массива через пробел циклом while

// int i = 0;
// while (i < array.Length)
// {
//     Console.Write($"{array[i]} ");
//     i++;
// }

// Вывод всего массива через пробел циклом for

// for (int i = 0; i < array.Length; i++) ;
// {
//     Console.Write($"{array[i]} ");
// }

// Вывод всего массива через цикл foreach

// foreach (int e in array);
// {
//     Console.Write($"{e} ");
// }

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] mas = new int[n];
// //Console.WriteLine(mas);

// //while 
// int ind = 0;
// while (ind < mas.Length)
// {
//   Console.Write($"{mas[ind]} ");
//   ind++;
// }
// Console.WriteLine();
// //for

// for (int i = 0; i < mas.Length; i++)
// {
//   Console.Write($"{mas[i]} ");
// }
// Console.WriteLine();

// //foreach
// foreach (var item in mas)
// {
//   Console.Write($"{item} ");
// }
// Console.WriteLine();

// //Печать массива
// void Print_mas(int[] col)
// {
//   foreach (var item in col)
//   {
//     Console.Write($"{item} ");
//   }
//   Console.WriteLine();
// }

// Print_mas(mas);

// // Случайные числа
// int[] Random_mas(int[] col)
// {
//   for (int i = 0; i < col.Length; i++)
//   {
//     col[i] = new Random().Next(1,10);
//   }
//   return col;
// }

// int[] new_mas = Random_mas(mas);
// Print_mas(new_mas);

// int m = Convert.ToInt32(Console.ReadLine());

// int coun = 0;

// for (int i = 0; i < new_mas.Length; i++)
// {
//   if(new_mas[i] == m) coun++;
// }

// if (coun == 0)
// {
//   Console.WriteLine($"Нет");
// }
// else
// {
//   Console.WriteLine($"Да");
// }


// int[] Read_mas(int[] col)
// {
//   for (int i = 0; i < col.Length; i++)
//   {
//     Console.Write($"Введите элемент массива {i + 1} из {col.Length}: ");
//     col[i] = Convert.ToInt32(Console.ReadLine());
//   }
//   return col;
// }

// int[] new_mas_2 = Read_mas(mas);
// Print_mas(new_mas_2);

// coun = 0;
// for (int i = 0; i < new_mas_2.Length; i++)
// {
//   if(new_mas_2[i] == m) coun++;
// }

// if (coun == 0)
// {
//   Console.Write($"Нет");
// }
// else
// {
//   Console.Write($"Да");
// }

// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// foreach (int e in array)
// {
//     Console.Write($"{e} ");
// }
// Console.WriteLine("");
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
//     Console.Write($"{array[i]} ");
// }

// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.

// Console.WriteLine("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int[] array2 = new int [n/2];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// foreach (int e in array)
// {
//     Console.Write($"{e} ");
// }
// Console.WriteLine("");
// for (int i = 0; i < array.Length/2; i++)
// {
//     array2[i] = array[i] * array[array.Length -i - 1 ];
//     Console.Write($"{array2[i]} ");
// }

//Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. 
// Младший разряд числа должен располагаться на 0-м индексе массива, старший – на 2-м. 

void PrintMas(int[] a)
{
    foreach (int e in a)
    {
        Console.Write($"{e} ");
    }
    Console.WriteLine(" ");
}

int n = new Random().Next(100,1000);
Console.WriteLine(n);
int[] arr = new int[3];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = n % 10;
    n /= 10;
}
PrintMas(arr);

