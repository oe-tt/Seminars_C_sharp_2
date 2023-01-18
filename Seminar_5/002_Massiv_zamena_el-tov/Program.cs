// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
Console.Clear();
int[] CreateRandomArray(int N, int start, int end)  // создаем массив случайных чисел
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)     // выводим массив на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] SmenaZnaka(int[] array)   // заменяем знак числа на противоположный
{
    for (int i = 0; i < array.Length; i++) array[i] *= -1;
    return array;
}

int[] Arr = CreateRandomArray(10, -100, 100);
ShowArray(Arr);
Arr = SmenaZnaka(Arr);
ShowArray(Arr);
