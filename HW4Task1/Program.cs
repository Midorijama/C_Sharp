
bool CheckForEvenNumberSum(int n)
{
    int s = 0;
    while (n > 0)
    {
        s = s + (n % 10);
        n = n / 10;
    }
    if (s % 2 == 0)
        return true;
    else
        return false;
}

string InputNumber()
{
    Console.WriteLine("Введите число:");
    string n = Console.ReadLine()!;
    return n;
}


while (true)
{
    string n = InputNumber();
    if (n == "q")
    {
        break;
    }
    else
    if (CheckForEvenNumberSum(Int32.Parse(n)))
    {
        break;
    }
}