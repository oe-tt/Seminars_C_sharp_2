// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[,] Min(int[,] array)                                       // метод для нахождения минимального элемента, номеров его строки и столбца
{
    int rows = array.GetLength(0);
    int colomns = array.GetLength(1);
    int min = array[0, 0];
    int iMin = 0; int jMin = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                iMin = i;
                jMin = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент массива = {min}, на строке № {iMin}, в столбце № {jMin}.");
    Console.WriteLine();
    int[,] arrayNoMin = new int[rows - 1, colomns - 1];           // массив без строки и столбца с минимальным элементом
    for (int i = 0; i < iMin; i++)
    {
        for (int j = 0; j < jMin; j++)
        {
            arrayNoMin[i, j] = array[i, j];
        }
        for (int j = jMin; j < colomns - 1; j++)
        {
            arrayNoMin[i, j] = array[i, j + 1];
        }
    }
    for (int i = iMin; i < rows - 1; i++)
    {
        for (int j = 0; j < jMin; j++)
        {
            arrayNoMin[i, j] = array[i + 1, j];
        }
        for (int j = jMin; j < colomns - 1; j++)
        {
            arrayNoMin[i, j] = array[i + 1, j + 1];
        }
    }
    return arrayNoMin;
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] Array = GetArray(m, n, 1, 100);
PrintArray(Array);
Console.WriteLine();
Array = Min(Array);
PrintArray(Array);
Console.WriteLine();