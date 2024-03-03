// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// Перевеси в char массив
// Перевернуть char массив (ReverseString(name, 0, right index))
// Перевернуть каждое слово цикл for ReverseString if right index == " " || == array.Lenght
// Переворот с leftidex до rightindex-1
// Перезаписать left index = right index + 1
// Left index = 0;
// right index = array.Length-1

Console.WriteLine("Введите строку символов");
string c = Console.ReadLine()!;

// int CountWords (string n)
// {
//     int count = 1;
//     for (int i = 0; i < n.Length; i++)
//     {
//         if (n[i] == ' ')
//         {
//             count = count+1;
//         }
//     }
//     return count;
// }

// void PrintArray(string[] arr)
// {
//     foreach (var item in arr)
//     {
//         Console.Write($"{item}, ");
//     }
//     Console.Write("\b\b ");
//     Console.WriteLine();
// }

// string[] CreateArrayOfStrings(string n, int c)
// {
//     string newstring = "";
//     string[] array = new string[c];    
//     for (int j = 0, i = 0; j < n.Length; j++)
//         {
//             if (n[j] == ' ')
//             {
//                 array[i] = newstring;
//                 newstring = "";
//                 i++;
//             }
//             else 
//             {
//                 newstring = newstring + n[j];
//             }
//         }    
//     return array;
// }

// string AddSpace (string n)
// {
//     n = n + " ";
//     return n;
// }

// string TurnArrayIntoString (string [] arr)
// {
//     string result = "";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result = result + arr[arr.Length - i -1] + " ";
//     }
//     return result;
// }


// Console.WriteLine("Введите строку символов");
// string c = Console.ReadLine()!;

// int count = CountWords(c);
// c = AddSpace(c);
// string [] array = CreateArrayOfStrings(c, count);
// // Console.WriteLine(count);
// // PrintArray(array);
// string result = TurnArrayIntoString(array);
// Console.WriteLine(result);