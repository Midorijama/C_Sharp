// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

bool CheckIfPolyndrome (string n)
{
    int m = n.Length-1;
    for (int i = 0; i < m/2; i++)
    {
        if(n[i] == n[m-i])
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Введите строку символов");
string c = Console.ReadLine()!;
if(CheckIfPolyndrome(c))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}