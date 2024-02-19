Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int d2 = n / 10 % 10;
int d3 = n % 10;
double result = Math.Pow(d2,d3);
Console.WriteLine(result);