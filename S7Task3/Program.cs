// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

string ReturnConsonants (string n)
{
    if (n.Length == 0)
    {
        return n;
    }
    string newstring = ReturnConsonants(n.Substring(0, n.Length-1));
    string newnew = "";
    if (n[n.Length-1] != 'a' && n[n.Length-1] != 'e' && n[n.Length-1] != 'u' && n[n.Length-1] != 'i' && n[n.Length-1] != 'o')
    {
        newnew = newstring + n[n.Length-1];
    }
    else
    {
        newnew = newstring;
    }
    return newnew;    
}



Console.WriteLine("Введите строку:");
string n = Console.ReadLine()!;
string newstring = ReturnConsonants(n);
Console.WriteLine(newstring);
