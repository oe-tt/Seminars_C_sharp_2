// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
        Console.WriteLine();
}

Console.Clear();
Console.Write("Введите длину стороны квадратного массива: ");
int n = int.Parse(Console.ReadLine());
int[,] Array = new int[n, n];
int Final = n * n;
int i = 0; int j = 0;
int iEndUp = 0; int jEndLeft = 0;
int iEndDown = n; int jEndRight = n;
int nEnd = 0;

// Console.WriteLine($"i={i}, j={j}");
// Console.WriteLine(nEnd);

for (j = jEndLeft; j < jEndRight; j++)      // идем направо 1
{
    Array[i, j] = nEnd + 1;        
    nEnd = Array[i, j];
}
j--;
jEndRight = j;

for (i = iEndUp + 1; i < iEndDown; i++)      // идем вниз
{
    Array[i, j] = nEnd + 1;
    nEnd = Array[i, j];
}
i--;
iEndDown = i;

for (j = jEndRight - 1; j >= jEndLeft; j--)      // идем налево 1
{
    Array[i, j] = nEnd + 1;
    nEnd = Array[i, j];
}
j++;
jEndLeft = j;

while (nEnd < n * n)
{
for (i = iEndDown - 1; i > iEndUp; i--)       // идем вверх
{
    Array[i, j] = nEnd + 1;
    nEnd = Array[i, j];
}
i++;
iEndUp = i;

for (j = jEndLeft + 1; j < jEndRight; j++)      // идем направо 2
{
    Array[i, j] = nEnd + 1;        
    nEnd = Array[i, j];
}
j--;
jEndRight = j;

for (i = iEndUp + 1; i < iEndDown; i++)      // идем вниз
{
    Array[i, j] = nEnd + 1;
    nEnd = Array[i, j];
}
i--;
iEndDown = i;

for (j = jEndRight - 1; j > jEndLeft; j--)      // идем налево 2
{
    Array[i, j] = nEnd + 1;
    nEnd = Array[i, j];
}
j++;
jEndLeft = j;

}
Console.WriteLine();
PrintArray(Array);