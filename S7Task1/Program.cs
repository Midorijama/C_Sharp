// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

int SumDigitsOfNumber (int n)
{    
    if (n == 0)
    {
        return 0;
    }    
    int res = SumDigitsOfNumber(n/10);
    int count = n%10 + res;
    return (count); 
    
}

Console.WriteLine("Write your number");
int n = Convert.ToInt32(Console.ReadLine());
int s = SumDigitsOfNumber(n);
Console.WriteLine(s);