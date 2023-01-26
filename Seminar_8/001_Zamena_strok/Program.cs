// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Console.Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)            // метод для создания массива вещественных чисел
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

int[,] RowReplaseArray(int[,] array)
{
    int iMax = array.GetLength(0);
    int jMax = array.GetLength(1);    
    int[] ArrayLine = new int[jMax];
    int k = 0;
    for (int j = 0; j < jMax; j++)                      // заносим первую строку в новый одномерный массив
    {
        ArrayLine[k] = array[0,j];
        k++;
    }

    for (int j = 0; j < jMax; j++)                      // заносим в первую строку значения из последней
    {
        array[0,j] = array[iMax-1,j];
    }

    k = 0;
    for (int j = 0; j < jMax; j++)                      // заносим в последнюю строку данные из временного одномерного массива
    {
        array[iMax-1,j] = ArrayLine[k];
        k++;
    }
    return array;
}

int[,] Array = GetArray(5, 7, -100, 100);
PrintArray(Array);
int[,] NewArray = RowReplaseArray(Array);
Console.WriteLine();
PrintArray(NewArray);