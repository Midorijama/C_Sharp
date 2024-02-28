// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

Console.WriteLine("Введите набор символов: ");
string c = Console.ReadLine()!;
string letters = "";
for (int i = 0; i < c.Length; i++)
{
    if (char.IsAsciiLetter(c[i]))
    {
        letters = letters + c[i];
    }
}
Console.WriteLine(letters);