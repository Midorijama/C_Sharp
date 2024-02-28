// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать массив, состоящий из цифр этой строки.


int NumberOfDigitsInString(string c)
{
    int s = 0;
    for (int i = 0; i < c.Length; i++)
    {
        if (char.IsAsciiLetter(c[i]))
        {
        }
        else
        {
            s = s + 1;
        }
    }
    return s;
}

string ExcludeLettersFromString (string c)
{
string newstring = "";
for (int j = 0; j < c.Length; j++)
{
    if (char.IsDigit(c[j]))
    {
        newstring = newstring + c[j];
    }
}
return newstring;
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

int[] ConvertNumberedStringToArray (string newstring, int s)
{
    int [] array = new int [s];
for (int i = 0; i < s; i++)
{
    array[i] = Convert.ToInt32(Convert.ToString(newstring[i]));
}
return array;
} 

Console.WriteLine("Введите набор символов: ");
string c = Console.ReadLine()!;
int s = NumberOfDigitsInString(c);
// Console.WriteLine(s);
string newstring = ExcludeLettersFromString(c);
// Console.WriteLine(newstring);
int [] array = ConvertNumberedStringToArray(newstring, s);
PrintArray(array);




