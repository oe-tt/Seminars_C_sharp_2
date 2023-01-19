// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Console.Clear();

int[] RandomArray(int N, int start, int end)          // метод для создания массива случайных чисел в заданном диапазоне
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

int PoiskCount(int[] array, int min, int max)        // метод для поиска количества заданных элементов массива
{
    int N = array.Length;
    int count = 0;
    for (int i = 1; i < N; i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    return count;
}

void PrintCount(int count, int min, int max)                         // метод для вывода результата посика
{
    if (count % 100 > 10 && count % 100 < 21)
    {
        Console.WriteLine($"В данном массиве {count} чисел в диапазоне от {min} до {max}.");
    }
    else
    {
        if (count % 10 == 1)
        {
            Console.WriteLine($"В данном массиве {count} число в диапазоне от {min} до {max}.");
        }
        else if (count % 10 > 1 && count % 10 < 5)
        {
            Console.WriteLine($"В данном массиве {count} числа в диапазоне от {min} до {max}.");
        }
        else Console.WriteLine($"В данном массиве {count} чисел в диапазоне от {min} до {max}.");
    }
}

int[] Array = RandomArray(123, -500, 500);
PrintArray(Array);
int Min = 10;
int Max = 99;
int Count = PoiskCount(Array, Min, Max);
PrintCount(Count, Min, Max);

