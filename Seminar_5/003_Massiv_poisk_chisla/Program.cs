// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Console.Clear();

int[] RandomArray(int N, int start, int end)           // метод для создания массива случайных чисел в заданном диапазоне
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(start, end + 1);
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

int PoiskNumber(int[] array, int number)                   // метод для поиска нужного числа
{
    int N = array.Length;
    int IndexNumber = -1;
    for (int i = 1; i < N; i++)
    {
        if (array[i] == number)  IndexNumber = i;
    }
    return IndexNumber;
}

void PrintNumber(int number)
{
    if (number == -1)
    {
        Console.WriteLine("Такого числа в массиве нет.");
    }
    else    Console.WriteLine($"Данное число есть в массиве в ячейке с индексом {number}.");
}

int[] Array = RandomArray(10, -100, 100);
PrintArray(Array);
Console.WriteLine("Введите число:");
int chislo = int.Parse(Console.ReadLine());
int Number = PoiskNumber(Array, chislo);
PrintNumber(Number);

