int[] arr = { 1, 5, -9, -4, 7, 4, -5, 6, 7, -1 };
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
    Console.Write($"{arr[i]}, ");
}
