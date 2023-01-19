// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
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

int [] ProizvParArray(int [] array)
{
    int N = array.Length;
    int [] ParArray = new int [N/2];
    for (int i = 0; i < N/2; i++)
    {
        ParArray[i] = array[i]*array[N-1-i];
    }   
    return ParArray; 
}



int[] Array = RandomArray(10, 1, 10);
PrintArray(Array);
int[] Pary = ProizvParArray(Array);
PrintArray(Pary);