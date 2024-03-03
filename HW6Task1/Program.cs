// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива.

string MakeStringFromMatrixArray (char[,] arr)
{
    string newstring = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newstring = newstring + Convert.ToString(arr[i,j]);
        }
    }
    return newstring;
}
void PrintMatrixArray(char[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr [i, j]}\t");
        }
        Console.WriteLine();
    }
}

char[,] FillMatrixArrayRandomly(int n, int m)
{
    char[,] array = new char[n,m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string chars = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";            
            int r = new Random().Next(0, chars.Length);
            array[i,j] = chars[r];
        }
    }
    return array;
}

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
char [,] array = FillMatrixArrayRandomly(n, m);
PrintMatrixArray(array);
string newstring = MakeStringFromMatrixArray(array);
Console.WriteLine(newstring);

