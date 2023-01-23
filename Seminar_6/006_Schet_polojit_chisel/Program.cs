// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

int[] EnterArray()                                      // метод для создания массива чисел, введенных с клавиатуры
{
    Console.WriteLine("Сколько чисел вы собираетесь ввести?");
    int M = int.Parse(Console.ReadLine());
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите целое число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int CountPozitiv(int[] array)                          // метод для подсчета положительных чисел в массиве
{
    int n = array.Length;
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] > 0)   count++;
    }
    return count;
}

void PrintArray(int[] array)                            // метод для вывода массива на экран
{
    Console.WriteLine("Ваш массив:");
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Array = EnterArray();
PrintArray(Array);
Console.WriteLine($"Количество положительных чисел в вашем массиве: {CountPozitiv(Array)}");


