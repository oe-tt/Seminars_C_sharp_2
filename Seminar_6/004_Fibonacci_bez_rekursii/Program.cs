// Не используя рекурсию, выведите первые N чисел Фибоначчи (начиная с 0 и 1).
Console.Clear();

int[] FibonacciArray(int N)           // метод для создания массива чисел Фибоначчи
{
    int[] array = new int[N];
    for (int i = 0; i < 2; i++)
    {
        array[i] = i;
    }
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-2] + array [i-1];
    }
    return array;
}

void PrintArray(int[] array)                          // метод для вывода массива на экран
{
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Числа Фибоначчи:");
PrintArray(FibonacciArray(n));
