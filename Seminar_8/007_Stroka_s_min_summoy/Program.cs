// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumLine(int[,] array)                                       // метод для нахождения строки с наименьшей суммой элементов
{
    int rows = array.GetLength(0);
    int colomns = array.GetLength(1);
    int[] sumOfRows = new int[rows];

    for (int i = 0; i < rows; i++)
    {
        int sumColomns = 0;
        for (int j = 0; j < colomns; j++)
        {
            sumColomns += array[i, j];
        }
        sumOfRows[i] = sumColomns;
        Console.WriteLine($"В строке {i} сумма элементов = {sumOfRows[i]}");
    }

    int minSum = sumOfRows[0];
    int iMinSum = 0;
    for (int i = 1; i < rows; i++)
    {
        if (sumOfRows[i] < minSum) 
        {
            minSum = sumOfRows[i];
            iMinSum = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"В строке {iMinSum} наименьшая сумма элементов ( {minSum} )");
    Console.WriteLine();
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] Array = GetArray(m, n, 1, 100);
PrintArray(Array);
Console.WriteLine();
MinSumLine(Array);