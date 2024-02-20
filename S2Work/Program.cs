// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Генерация рандомного числа, в генерации числа из условия не включены в генерацию
// int num = new Random().Next(50, 2000);
// Console.WriteLine(num);
// Решение через int
// if(num <= 999 && num >=100 )
// {
//     int num1 = num / 100;
//     int num3 = num % 10;
//     Console.WriteLine(num1 * 10 + num3);
// }
// else
// {
//     Console.WriteLine("Введено не трехзначное число");
// }
// Решение через стринг

// int num = new Random().Next(50, 2000);
// Console.WriteLine(num);
// string num_st = Convert.ToString(num);
// if(num_st.Length == 3)
// {
//     int num1 = Convert.ToInt32(Convert.ToString(num_st[0]));
//     int num3 = Convert.ToInt32(Convert.ToString(num_st[2]));
//     Console.WriteLine(num1 * 10 + num3);
// }
// else
// {
//     Console.WriteLine("Введено не трехзначное число");
// }

//Задача 2
//Напишите программу, которая принимает на 
//вход трёхзначное число и возводит 
//вторую цифру этого числа в степень, 
//равную третьей цифре.
// Console.WriteLine("Введите трехзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = a / 10 % 10;
// int c = a % 10;
// Console.WriteLine(Math.Pow(b,c));

//Задача 3
// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, 
// то программа выводит остаток от деления.

// Console.Write("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if(b == 0)
// {
//     Console.WriteLine("Деление на ноль невозможно");
// }
// else
// {
//     if(a % b == 0)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine($"Нет, {a % b}");
//     }
// }
// Задача 4
// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// Поиск числа с начала
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a < 100)
// {
//     Console.WriteLine("Third number doesb't exist");
// }
// else
// {
//     while (a > 999)
//     {
//         a /= 10;
//     }
//     Console.WriteLine(a % 10);
// }
// 3 число с конца через математику
// int num = 123456;
// Console.WriteLine(num / 100 % 10);