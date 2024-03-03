// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.

char[] FillArrayFromKeyboard(int n)
{
    char[] array = new char[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент {i + 1} массива из {array.Length}: ");
        array[i] = Convert.ToChar(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(char[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}

string MakeStringFromArray (char[] arr)
{
    string newstring = "";
    for (int i = 0; i < arr.Length; i++)
    {
        newstring = newstring + Convert.ToString(arr[i]);
    }
    return newstring;
}

Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
char [] array = FillArrayFromKeyboard(n);
string newstring = MakeStringFromArray(array);
Console.WriteLine(newstring);