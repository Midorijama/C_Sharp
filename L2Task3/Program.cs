int[] arr = { 1, 2, 5, 9, 4, 1, 5, 9, 4, 45 };
int i = 0;
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.WriteLine(arr[i]);
    }
    i = i + 1;
}
