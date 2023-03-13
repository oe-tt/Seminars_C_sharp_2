// Сортировка выбором (по возрастанию)
Console.Clear();
// int n = 8;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = new Random().Next(1, 20);
//     Console.Write($"{array[i]} ");
// }
// Console.WriteLine();
// for (int current = 0; current < n; current++)
// {
//     for (int i = current; i < n; i++)
//     {
//         if (array[current] > array[i])
//         {
//             int temp = array[i];
//             array[i] = array[current];
//             array[current] = temp;
//         }
//     }
//     for (int i = 0; i < n; i++)     Console.Write($"{array[i]} ");
// Console.WriteLine();
// }

// оптимизированный вариант
Console.WriteLine("Исходный массив:");
int n = 8;
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
Console.WriteLine("Сортировка:");
for (int current = 0; current < n; current++)    // меньше итераций
{
    for (int i = current; i < n - current; i++)
    {
        if (array[current] > array[i])
        {
            int temp = array[i];
            array[i] = array[current];
            array[current] = temp;
        }
    }
    for (int i = 0; i < n; i++)     Console.Write($"{array[i]} ");
Console.WriteLine();
}    