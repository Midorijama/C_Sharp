int FirstDigit (int N)
{
    int d = N;
    while (N > 9) // Цикл вычисляет первую цифру числа
    {
        N /= 10;
        d = N;        
    }
    return d;
}

int RemoveFirstDigit (int N)
{
    int p = 1;
    while (N / p > 9) // Цикл вычисляет степень кратности 10 (количество цифр в числе)
    {
        p *= 10;
    }
    N = N % p; // Убирает первую цифру числа
    return N;
}

int CountDigit (int N)
{
    int DigitAmount = 1;
    int p = 1;
    while (N / p > 9) // Цикл вычисляет степень кратности 10 (количество цифр в числе)
    {
        p = p * 10;
        DigitAmount = DigitAmount + 1;
    }    
    return DigitAmount;
}


int N = new Random().Next(1, 100001) ;
int da = CountDigit(N);
int [] array = new int [da];
array[0] = FirstDigit(N);
for (int i = 1; i < array.Length; i++)
{
    N = RemoveFirstDigit(N);
    array[i] = FirstDigit(N);    
}
foreach (var item in array)
{
    Console.Write($"{item}, ");
}
Console.Write("\b\b  ");