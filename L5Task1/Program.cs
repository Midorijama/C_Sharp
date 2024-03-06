int Factorial (int n)
{
    if (n == 1)
    {               
        return 1;
    }       
    int res = Factorial(n-1);
    Console.WriteLine($"For {n} factorial would be {n*res}");   
    return n * res; 
    
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(n));
