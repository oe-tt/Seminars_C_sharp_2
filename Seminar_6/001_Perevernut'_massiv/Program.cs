// Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

int [] PerevorotArray(int [] array)
{
    int N = array.Length;
    int temp = 0;
    for (int i = 0; i < N/2; i++)
    {
        temp = array[i];
        array[i] = array[N-1-i];
        array[N-1-i] = temp;
    }   
    return array; 
}



int[] Array = RandomArray(10, -100, 100);
PrintArray(Array);
PerevorotArray(Array);
PrintArray(Array);