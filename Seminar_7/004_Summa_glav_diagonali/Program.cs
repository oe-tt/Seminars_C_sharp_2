// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
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

int Summa(int[,] array)                                           // метод для подсчета элементов на диагонали
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < m; i++)
    {
        int j = i;
        sum += array[i, j];
    }
    return sum;
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] Array = GetArray(m, n, 1, 100);
PrintArray(Array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов диагонали массива = {Summa(Array)}");
