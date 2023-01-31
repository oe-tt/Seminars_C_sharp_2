// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SredneeStolb(int[,] array)                                       // метод для подсчета среднего арифметического столбцов
{
    int rows = array.GetLength(0);
    int colomns = array.GetLength(1);
    int[] sumColomns = new int[colomns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            sumColomns[j] = sumColomns[j] + array[i, j];
        }

    }

    for (int j = 0; j < colomns; j++)
    {
        Console.WriteLine($"Сумма значений столбца с индексом {j} = {sumColomns[j]}");
    }

    Console.WriteLine();
    int[] sredColomns = new int[colomns];
    for (int j = 0; j < colomns; j++)
    {
        sredColomns[j] = sumColomns[j] / rows;
        Console.WriteLine($"Среднее значение столбца с индексом {j} = {sredColomns[j]}");
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] Array = GetArray(m, n, 1, 500);
PrintArray(Array);
Console.WriteLine();
SredneeStolb(Array);