// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

double[,] GetArray(int m, int n, int minValue, int maxValue)            // метод для создания массива вещественных чисел
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)                                        // метод для вывода массива на экран
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


void FindNomber(double[,] array)                                       // метод для поиска элемента в массиве по его номеру
{
    Console.WriteLine("Введите номер элемента массива (начиная с № 1):");
    int nomber = int.Parse(Console.ReadLine());
    int rows = array.GetLength(0);
    int colomns = array.GetLength(1);
    if (nomber == 1) Console.WriteLine($"Элемент массива [0,0]: {array[0, 0]}");
    else if (nomber < 1 || nomber > rows * colomns) Console.WriteLine("Такого элемента в массиве нет");
    else
    {
        int k = nomber / colomns;
        int l = nomber % colomns - 1;
        if (nomber <= colomns) Console.WriteLine($"Элемент массива [0,{nomber - 1}]: {array[0, nomber - 1]}");
        else
        {
            if (nomber % colomns == 0)
            {
                k = k - 1;
                l = colomns - 1;
                Console.WriteLine($"k = {k}, l = {l}");
                Console.WriteLine($"Элемент массива [{k},{l}]: {array[k, l]}");
            }
            else
            {
                Console.WriteLine($"k = {k}, l = {l}");
                Console.WriteLine($"Элемент массива [{k},{l}]: {array[k, l]}");
            }
        }
    }
}

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

double[,] Array = GetArray(m, n, -100, 100);
PrintArray(Array);
FindNomber(Array);