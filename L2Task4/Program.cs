int[] arr = { 1, 5, 9, 34, 7 };
int i = 0;
int max = arr[i];
while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);
