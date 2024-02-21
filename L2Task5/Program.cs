int[] arr = { 1, 5, 9, 34, 7 };
// int i = 0;
// int max = arr[i];
// while (i < arr.Length)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     i = i + 1;
// }

int max = arr[0];
// for (int j =0; j<arr.Length; j++)
// {
//     if (arr[j] > max)
//     {
//         max = arr[j];
//     }
// }

foreach (int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);