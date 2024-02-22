// double[] array = { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 };
// double max = array[0];
// double min = array[0];
// foreach (double e in array)
// {
//     if (e > max)
//         max = e;
// }
// foreach (double e in array)
// {
//     if (e < min)
//         min = e;
// }
// Console.WriteLine(max - min);

class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        double min = numbers[0];
        foreach (double e in numbers)
        {
            if (e < min)
            min = e;
         }
        return min;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        double max = numbers[0];
        foreach (double e in numbers)
        {
            if (e > max)
            max = e;
        }
        return max;
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        double z = FindMax(array) - FindMin(array);
        Console.WriteLine(FindMax(array));
        Console.WriteLine(FindMin(array));
        Console.WriteLine(z);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}