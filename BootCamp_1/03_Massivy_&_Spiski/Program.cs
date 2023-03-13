// See https://aka.ms/new-console-template for more information
Console.Clear();
int n = 5;
int[] array = new int[n];
for (int k = 0; k < n; k++)
    array[k] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(" ", array));         // string.Join(" " - вывод в строку через указанный в кавычках разделитель
// или так:
Console.WriteLine("[" + string.Join(", ", array) + "]");

// 1
Console.WriteLine(array[3]);
// Сложность алгоритма 1 = O(1) 
// - сколько действий выполнено, чтобы узнать конечный результат (элемент массива №3)

// 2
int sum = 0;
for (int k = 0; k < n; k++)
    sum += array[k];
Console.WriteLine(sum);
// Сложность алгоритма 2 = 0(n) = 5
// - столько действий выполнено для вычисления суммы массива

// 3 - быстрая сортировка массива
// Сложность алгоритма 3 = O(n * log n)



// Талица умножения до указанного числа
// алгоритм 4
// 1. Длинный способ через двумерный массив
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int[,] TablUmn = new int[N, N];
int i = 0;
int j = 0;
for (j = 0; j < N; j++)
{
    TablUmn[i, j] = j + 1;
    Console.Write($"{TablUmn[i, j]} ");
}
Console.WriteLine();
for (i = 1; i < N; i++)
{
    TablUmn[i, 0] = TablUmn[i - 1, 0] + 1;
    Console.Write($"{TablUmn[i, 0]} ");
    for (j = 1; j < N; j++)
    {
        TablUmn[i, j] = (TablUmn[i, 0]) * TablUmn[0, j];
        Console.Write($"{TablUmn[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// 2. Короткий способ через циклы без двумерного массива!
for (i = 1; i <= N; i++)
{
    for (j = 1; j <= N; j++)
    {
        Console.Write(i * j);
        Console.Write("\t");
    }
    Console.WriteLine();
}
// Сложность алгоритма 4.2 = O(n^2)

// 3. Еще более короткий способ через матрицу (здесь - квардартный двумерный массив)
// Алгоритм 5
// !!! Не работает, надо разобраться и довести до ума!
// Console.WriteLine("Алгоритм 5");
// int[,] matrix1 = new int[N, N];
// for (i = 1; i <= N; i++)
// {
//     for (j = 1; j <= N; j++)
//     {
//         if (i + j < N)
//         {
//             matrix1[i, j] = i * j;
//             matrix1[j, i] = i * j;
//         }
//     }
// }
// for (i = 1; i <= N; i++)
// {
//     for (j = 1; j <= N; j++)
//     {
//         Console.Write(matrix1[i, j]);
//         Console.Write("\t");
//     }
//     Console.WriteLine();
// }
// Сложность алгоритма 5 все еще = O(n^2)

// 4. Оптимальный способ через матрицу 
// Алгоритм 6
// Console.WriteLine();
Console.WriteLine("Алгоритм 6. Оптимальный!");
int[,] matrix2 = new int[N, N];
for (i = 0; i < N; i++)
{
    for (j = i; j < N; j++)
    {
        matrix2[i, j] = (i + 1) * (j + 1);
        matrix2[j, i] = (i + 1) * (j + 1);
    }
}
for (i = 0; i < N; i++)
{
    for (j = 0; j < N; j++)
    {
        Console.Write(matrix2[i, j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
// Сложность алгоритма 6 = O((n^2) /2)