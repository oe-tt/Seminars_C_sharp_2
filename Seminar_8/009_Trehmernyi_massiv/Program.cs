// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("************");

int[,,] GetThreeArray(int n, int m, int o)            // метод для создания трехмерного массива целых двузначных чисел
{
    int[,,] array = new int[n, m, o];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < o; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)                                        // метод для вывода массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] ChekArray(int[,,] array)                                        // проверка массива на повторы
{
    int[] ChekArrayLine(int[] ArrayLine)                                            // проверка одномерного массива
    {
        int dlinaLine = ArrayLine.GetLength(0);
        for (int iLine = 1; iLine < dlinaLine; iLine++)
        {
            int iEndTemp = iLine;
            for (int iLineTemp = 0; iLineTemp < iEndTemp; iLineTemp++)
            {
                while (ArrayLine[iLineTemp] == ArrayLine[iLine])
                {
                    ArrayLine[iLine] = new Random().Next(10, 100);
                }
            }
            for (int iLineTemp = 0; iLineTemp < dlinaLine - 1; iLineTemp++)
            {
                while (ArrayLine[iLineTemp] == ArrayLine[dlinaLine - 1])
                {
                    ArrayLine[dlinaLine - 1] = new Random().Next(10, 100);
                }
            }
        }
        return ArrayLine;
    }

    int dlinaLine = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);               // преобразование трехмерного массива в одномерный
    int[] ArrayLine = new int[dlinaLine];
    int iLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                ArrayLine[iLine] = array[i, j, k];

                // Console.Write($"iLine = {iLine} ; ArrayLine = {ArrayLine[iLine]}");
                // Console.WriteLine();
                iLine++;
            }
        }
    }
    Console.WriteLine();
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);
    ChekArrayLine(ArrayLine);


    // for (iLine = 0; iLine < dlinaLine; iLine++)
    // {
    //     Console.Write($"iLine = {iLine} ; ArrayLine = {ArrayLine[iLine]}");
    //     Console.WriteLine();
    // }

    iLine = 0;
    for (int i = 0; i < array.GetLength(0); i++)                        // преобразование одномерного массива в трехмерный
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = ArrayLine[iLine];
                iLine++;
            }
        }
    }

    return array;
}

Console.WriteLine("Введите размеры трехмерного массива. Количество элементов массива должно быть не более 90.");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int o = int.Parse(Console.ReadLine());
while (n * m * o > 90)
{
    Console.WriteLine("Количество элементов массива должно быть НЕ БОЛЕЕ 90!");
    n = int.Parse(Console.ReadLine());
    m = int.Parse(Console.ReadLine());
    o = int.Parse(Console.ReadLine());
}

Console.WriteLine();
int[,,] Array = GetThreeArray(n, m, o);
Console.WriteLine("Исходный массив двузначных чисел:");
Console.WriteLine();
PrintArray(Array);
Console.WriteLine();
Array = ChekArray(Array);
Console.WriteLine("Массив без повторов");
Console.WriteLine();
PrintArray(Array);
Console.WriteLine();