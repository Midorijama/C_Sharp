// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.

// string CharsOfString (char [] arr)
// {
//     string st = "";
//     foreach (var item in arr)
//     {
//         st +=item;
//     }
//     return st;
// }

// char [] chars = new char [] {'a', 'b', 'c', 'd'};
// Console.WriteLine(CharsOfString(chars));

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных (aouei).

int CountVowels (string st)
{
    int s = 0;
    for (int i = 0; i < st.Length; i++)
    {
        if (st[i] == 'a' || st[i] == 'e' || st[i] == 'u' || st[i] == 'i' || st[i] == 'o' 
        || st[i] == 'A' || st[i] == 'E' || st[i] == 'U' || st[i] == 'I' || st[i] == 'O')
        {
            s++;
        }
    }
    return s;
}

bool CheckIfLetter (string st)
{
    for (int i = 0; i < st.Length; i++)
    {
        if (char.IsLetter(st[i]) || st[i] == ' ')
        {
        }
        else
        {
            return false;
        }            
    }
    return true;
}

string st = Console.ReadLine()!;
if (CheckIfLetter(st))
{
    int vowels = CountVowels(st);
    Console.WriteLine(vowels);
}
else
{
    Console.WriteLine("Введен неверный формат");
}
