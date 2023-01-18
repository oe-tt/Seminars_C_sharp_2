// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int [] A;

int[] RandomArray (int N, int start, int end)    // Создаем метод для создания массива случайных чисел в заданном диапазоне
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void PrintArray (int [] array)          // Создаем метод для вывода массива на экран
{
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите нижнюю границу диапазона:");
int Amin = int.Parse(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу диапазона:");
int Amax = int.Parse(Console.ReadLine());

A = RandomArray(8, Amin, Amax);
PrintArray(A);