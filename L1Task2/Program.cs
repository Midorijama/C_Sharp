int a = 2;
int b = 5;
int c = 8;
int d = 4;
int e = 9;
int max = a;

if(max < b)
{
    max = b;
}
if(max < c)
{
    max = c;
}
if(max < d)
{
    max = d;
}
if(max < e)
{
    max = e;
}

Console.WriteLine(max);