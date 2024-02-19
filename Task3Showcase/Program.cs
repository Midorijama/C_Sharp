Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a / 100;
int c = a % 10;
int sum = b + c;
Console.WriteLine(sum);