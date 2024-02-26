int[] FillArrayRandomly(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}

double TurnArrayIntoNumberBackwards(int[] arr)
{
    double s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        double p = Math.Pow(10, i);
        s = s + arr[i]*p;
    } 
    return s;
}

int CountDigits(double N)
{
    int DigitAmount = 1;
    int p = 1;
    int n = Convert.ToInt32(N);
    while (N / p > 10)
    {
        p = p * 10;
        DigitAmount = DigitAmount + 1;
    }
    Console.WriteLine(DigitAmount);
    return DigitAmount;
}

int [] NumbertoArrayStraight (double n, int a)
{
    int [] arr = new int [a];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[arr.Length - i - 1] = Convert.ToInt32(n) % 10;
        n = Convert.ToInt32(n)/10;
    }
    return arr;
}

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = FillArrayRandomly(n);
PrintArray(a);
double count = TurnArrayIntoNumberBackwards(a);
Console.WriteLine(count);
int digits = CountDigits(count);
int [] array = NumbertoArrayStraight(count, digits);
PrintArray(array);