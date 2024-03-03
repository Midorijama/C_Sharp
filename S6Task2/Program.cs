// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

void PrintArray(char[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}


char [] CreateArrayFromString (string n, int s)
{
    char [] array = new char [s];
    for (int i = 0; i < s; i++)
    {
        array[i] = Convert.ToChar(n[i]);
    }
    return array;
}

Console.WriteLine("Введите строку символов");
string c = Console.ReadLine()!;
int s = c.Length;
char [] array = CreateArrayFromString(c,s);
PrintArray(array);