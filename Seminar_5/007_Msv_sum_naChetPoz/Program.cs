// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

int CountNechetPosition(int[] array)                            // метод для суммирования чисел на нечетных позициях массива 
{
    int N = array.Length;
    int sum = 0;
    for (int i = 1; i < N; i+=2)    sum += array[i];
    return sum;
}

int[] Array = RandomArray(20, 1, 100);
PrintArray(Array);
Console.WriteLine($"Сумма чисел на нечетных позициях массива = {CountNechetPosition(Array)}");