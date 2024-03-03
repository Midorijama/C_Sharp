// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.

int CountVowelsInString(string n)
{
    int s = 0;
    for (int i = 0; i < n.Length; i++)
    {
         if (n[i] == 'a' || n[i] == 'e' || n[i] == 'u' || n[i] == 'i' || n[i] == 'o')
                {
                    s = s + 1;
                }
            }       
        return s;
        }
     
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

bool CheckIfLower(string n)
{
    for (int i = 0; i < n.Length; i++)
    {
        if (!char.IsLower(n[i]))
        {
            return false;
        }                 
    } 
    return true;   
}

Console.WriteLine("Введите строку символов");
string c = Console.ReadLine()!;
int s = 0;
if (CheckIfLetter(c) && CheckIfLower(c))
{
   s = CountVowelsInString(c);
   Console.WriteLine(s);
}
else 
{
    Console.WriteLine("Введен недопустимый символ");
}
