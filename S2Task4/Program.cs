Console.Write("Введите число: ");
string a = Console.ReadLine()!;
int l = a.Length;
if (l>=3)
{
    Console.WriteLine(a[l-3]);
}
else
{
    Console.WriteLine("These aren't the droids you're looking for");
}