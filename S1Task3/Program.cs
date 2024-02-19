Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int q1 = n / 100;
int q2 = n / 10;
int q_count = q2 * 10;
int q3 = n - q_count;
int sum = q1 + q3;

Console.WriteLine(sum);