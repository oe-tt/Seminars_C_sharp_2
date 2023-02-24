// Посчитать сумму всех троек (пятерок и т.д. - любого количества последовательностей чисел) массива
Console.Clear();
int[] CreateArray(int n) => new int[n];  // краткая запись метода (тело метода см.ниже)
// {
//     return new int [n];
// }

void FillArray(ref int[] array) => array = array.Select(a => Random.Shared.Next(10)).ToArray();
// краткая запись заполнения ЗАМЕНОЙ ref массива случайными числами от 0 до 10

string PrintArray(int[] array) => $"[{String.Join(", ", array)}]";  // краткая запись созздания строки из массива для печати

// int[] GetRangeSum(int[] array, int m) // подсчет суммы указаного количества элементов массива
// {
//     int n = array.Length;
//     int[] summa = new int[n - m +1];
//     int k = 0;
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = i; j <= m; j++)
//         {
//             summa[k] += array[j];
//         }
//         k++;
//     }
//     return summa;
// }

int[] GetRangeSum1(int[] array, int m) // подсчет суммы указаного количества элементов массива
// метод рабочий, но не эффективный при большом количестве элементов
{
    int n = array.Length;
    int[] summa = new int[n - m + 1];
    int k = 0;
    for (int i = 0; i <= n - m; i++)
    {
        for (int j = i; j < i + m; j++)
        {
            summa[k] += array[j];
        }
        k++;
    }
    return summa;
}

int[] GetRangeSum2(int[] array, int m) // подсчет суммы указаного количества элементов массива
// более эффективный метод
{
    int n = array.Length;
    int[] summa = new int[n - m + 1];
    int k = 0;
    for (int i = 0; i < m; i++)
    {
        summa[k] += array[i];
    }
    k=1;
    for (int i = 1; i <= n - m; i++)
    {
        summa[k] = summa[k-1] - array[i - 1] + array[i + m -1];
        k++;
    }
    return summa;
}

Console.Write("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] Array = CreateArray(n);
FillArray(ref Array);
Console.WriteLine(PrintArray(Array));

Console.Write("Введите размер суммируемых последовательностей элементов массива: ");
int m = int.Parse(Console.ReadLine()!);
int[] SumArray1 = GetRangeSum1(Array, m);
Console.WriteLine(PrintArray(SumArray1));
int[] SumArray2 = GetRangeSum2(Array, m);
Console.WriteLine(PrintArray(SumArray2));