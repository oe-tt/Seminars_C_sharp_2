// Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] RandomArray(int N, int start, int end)           // метод для создания массива случайных чисел в заданном диапазоне
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array)                          // метод для вывода массива на экран
{
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void CountChet(int[] array)                            // метод для подсчета четных чисел в массиве
{
    int N = array.Length;
    int count = 0;
    for (int i = 0; i < N; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в данном массиве = {count}");
}

int[] Array = RandomArray(20, 100, 999);
PrintArray(Array);
CountChet(Array);