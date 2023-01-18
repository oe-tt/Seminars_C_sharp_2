// Сортировка массива
Console.Clear();
int [] arr = { 1, 5, 3, 6, 8, 3, 2, 1, 4, 5, 7};

void PrintArray (int [] array)          // Создаем метод для вывода массива на экран
{
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);

void SortArray (int [] array)           // Создаем метод для сортировки массива
{
       for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])  minPosition = j;
        }

        int temporary = array[i]; 
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    Console.WriteLine();
}

SortArray(arr);
PrintArray(arr);