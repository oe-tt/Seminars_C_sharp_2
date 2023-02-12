// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int Count(int[,] array, int n)                                       // метод для нахождения частоты встречаемости элемента
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == n) count++;
        }
    }
    return count;
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] Array = GetArray(m, n, 1, 100);
PrintArray(Array);
Console.WriteLine();
Console.Write("Введите число для поиска: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Число {number} встретилось в массиве {Count(Array, number)} раз");
Console.WriteLine();