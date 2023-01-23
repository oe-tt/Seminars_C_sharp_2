// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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

int[] CopyArray(int[] origin)                          // метод для создания копии массива
{
    int n = origin.Length;
    int[] copy = new int[n];
    for (int i = 0; i < n; i++)
    {
        copy [i] = origin [i];
    }
    return copy;
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

int[] Array = RandomArray(10, 1, 10);
Console.WriteLine("Оригинальный массив:");
PrintArray(Array);
Console.WriteLine("Копия массива:");
PrintArray(CopyArray(Array));
