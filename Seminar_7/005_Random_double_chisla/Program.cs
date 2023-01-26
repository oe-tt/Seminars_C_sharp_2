// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

double[,] GetArray(int m, int n, int minValue, int maxValue)            // метод для создания массива вещественных чисел
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(), 3);
        }
    }
    return result;
}

void PrintArray(double[,] array)                                        // метод для вывода массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

double[,] array = GetArray(m, n, -100, 100);
PrintArray(array);