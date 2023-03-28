// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetRandomArray(4, 100, 1000);
Console.WriteLine($"[{(String.Join(",", array))}]");

int FindElements(int[] Array)
{

    int count = 0;
    foreach (int item in Array)
    {
        if (item%2 == 0) count++;
    }
    return count;
}

int result = FindElements(array);

Console.WriteLine($"В данном массиве -> четных чисел {result}");

// ----------------Общий метод------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)
// [3, 7.4, 22.3, 2, 78] -> 76
