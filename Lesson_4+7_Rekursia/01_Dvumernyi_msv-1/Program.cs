// Двумерные массивы
Console.Clear();

/* string[,] table = new string[2, 5];
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"*{table[rows, columns]}");
    }
} */

int[,] matrix = new int[2, 4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");    // чтобы выводить все элементы одной строки в одной строке
    }
    Console.WriteLine();                    // чтобы выводить новую строку на следующей строке
}
Console.WriteLine();

// ***.GetLength(0) - количество строк массива   !!!
// ***.GetLength(1) - количество столбцов        !!!
// (*** - название массива)


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();     
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);    // интервал [1;10) = [1;9]
        }
    }
}

int[,] Matrix = new int[3, 5];
PrintArray(Matrix);
Console.WriteLine();
FillArray(Matrix);
PrintArray(Matrix);

