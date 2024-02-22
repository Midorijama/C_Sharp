int[] array = { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 };
int c = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) 
    c = c + 1;
}
//return c
Console.Write(c);