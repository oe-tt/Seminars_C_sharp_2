// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] Proizv(int[,] arrayA, int[,] arrayB)                                       // метод для умножения матриц
{
    int rowsA = arrayA.GetLength(0);
    int colomnsA = arrayA.GetLength(1);
    int rowsB = arrayB.GetLength(0);
    int colomnsB = arrayB.GetLength(1);
    int[,] umnoj = new int[rowsA, colomnsB];
    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colomnsB; j++)
        {
            umnoj[i, j] = 0;
            for (int k = 0; k < colomnsA; k++)
            {
                umnoj[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return umnoj;
}

Console.Write("Введите количество строк матрицы А: ");
int mA = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы А = количество строк матрицы B: ");
int nA = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы B: ");
int nB = int.Parse(Console.ReadLine());

int[,] MatrixA = GetArray(mA, nA, 1, 10);
PrintArray(MatrixA);
Console.WriteLine();
int[,] MatrixB = GetArray(nA, nB, 1, 10);
PrintArray(MatrixB);
Console.WriteLine();
int[,] Array = Proizv(MatrixA, MatrixB);
PrintArray(Array);
Console.WriteLine();