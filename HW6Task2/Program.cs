// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

bool CheckIfLetter(string n)
{
    for (int i = 0; i < n.Length; i++)
    {
        if (!char.IsLetter(n[i]))
        {
            return false;
        }            
    } 
    return true;   
}

string ConvertUpperToLowerRegister (string n)
{
    string newstring = n.ToLower();
    return newstring;
}

Console.WriteLine("Введите строку символов");
string c = Console.ReadLine()!;
if (CheckIfLetter(c))
{
    c = ConvertUpperToLowerRegister(c);
    Console.WriteLine(c);
}
else
{
    Console.WriteLine(c);
}