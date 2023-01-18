// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Console.Clear();

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] Array1 = CreateRandomArray(12, -9, 9);
ShowArray(Array1);

int polojit = 0;
int otrits = 0;

for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i]>0)
    {
        polojit += Array1[i];
    }
    else{
        otrits += Array1[i];
    }
}

Console.WriteLine($"Сумма положительных чисел массива = {polojit}\nСумма отрицательных чисел массива = {otrits}");

