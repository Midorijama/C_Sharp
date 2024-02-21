Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = { 1, 5, 9, 34, 7 };
string a = "No";

foreach (int e in arr)
    if (e == n)
    {

        a = "Yes";
    }
Console.WriteLine(a);