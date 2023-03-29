// // Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// int[] array = GetRandomArray(4, 100, 1000);
// Console.WriteLine($"[{(String.Join(",", array))}]");

// int FindElements(int[] Array)
// {

//     int count = 0;
//     foreach (int item in Array)
//     {
//         if (item%2 == 0) count++;
//     }
//     return count;
// }

// int number = FindElements(array);

// Console.WriteLine($"В данном массиве -> четных чисел {number}");

// // ----------------Общий метод------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }

// // Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных индексах.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// int[] array = GetRandomArray(4, -10, 10);
// Console.WriteLine($"[{(String.Join(",", array))}]");

// int SumElements(int[] Array)
// {
//     int sum =0;
//     for (int i = 0; i < Array.Length; i++)
//     {
//         if (i % 2 != 0) sum += Array[i];     
//     }
//     return sum;
// }

// Console.WriteLine($" -> сумма элементов, стоящих на нечётных индексах {SumElements(array)}");

// // ----------------Общий метод------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }
//     return result;
// }

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)
// [3, 7.4, 22.3, 2, 78] -> 76

double[] array = GetRandomArray(5, 0, 99);
Console.WriteLine($"[{(String.Join("; ", array))}]");


double res = Math.Round(SumMinMax(array), 1); // округляем результат до 1 знака после запятой
Console.WriteLine($" -> сумма максимального и минимального элементов -> {res}");

// --------------Метод поиска разницы------------------
double SumMinMax(double[] Array)
{
    double sum = 0;

    for (int i = 0; i < Array.Length; i++)
    {
        double max = Array[0];
        double min = Array[0];
        foreach (double item in Array)
        {
            if (max < item) max = item;
            if (min > item) min = item;
        }
        sum = min + max;
    }
    return sum;
}

// ----------------Общий метод заполнения массива вещественными числами------------------
double[] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * 100, 1);
    }
    return result;
}