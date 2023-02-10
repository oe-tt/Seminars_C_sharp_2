// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)            // метод для создания массива целых чисел
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)                                        // метод для вывода массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Sortirovka(int[,] array)                                       // метод для сортировки по убыванию элементов каждой строки двумерного массива
{
    int rows = array.GetLength(0);
    int colomns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int jTemp = 0;
        for (int j = 0; j < colomns; j++)
        {
            for (int k = jTemp; k < colomns; k++)
            {
                if (array[i, k] > array[i, jTemp])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, jTemp];
                    array[i, jTemp] = temp;
                }
            }
            jTemp++;
        }
    }
    return array;
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] Array = GetArray(m, n, 1, 100);
Console.WriteLine();
Console.WriteLine("Исходный массив");
PrintArray(Array);
Console.WriteLine();
Sortirovka(Array);
Console.WriteLine("Отсортированный по строкам массив");
PrintArray(Array);
Console.WriteLine();
