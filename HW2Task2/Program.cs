// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
Console.Write("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X == 0 || Y == 0)
{
    Console.WriteLine("Одна из координат лежит на оси");
}
else if (X > 0 && Y > 0)
{
    Console.WriteLine("I");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("II");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("III");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("IV");
}