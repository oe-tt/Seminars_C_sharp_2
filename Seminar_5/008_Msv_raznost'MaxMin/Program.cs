// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
Console.Clear();

double[] RandomArray(int N, int start, int end)           // метод для создания массива случайных вещественных чисел в заданном диапазоне
{
    double[] array = new double[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(start, end + 1) + Math.Round(new Random().NextDouble(), 3);
    }
    return array;
}

void PrintArray(double[] array)                          // метод для вывода массива на экран
{
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

double minArray(double[] array)                          // метод для нахождения минимального элемента массива
{
    int N = array.Length;
    double min = array[0];
    for (int i = 0; i<N; i++)
    {
        if (array[i]<min)   min = array[i];
    }
    return min;
}

double maxArray(double[] array)                          // метод для нахождения максимального элемента массива
{
    int N = array.Length;
    double max = array[0];
    for (int i = 0; i<N; i++)
    {
        if (array[i]>max)   max = array[i];
    }
    return max;
}

double[] Array = RandomArray(10, -100, 100);
PrintArray(Array);
Console.WriteLine($"Минимальный элемент массива = {minArray(Array)}; максимальный элемент массива = {maxArray(Array)}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {maxArray(Array) - minArray(Array)}");
