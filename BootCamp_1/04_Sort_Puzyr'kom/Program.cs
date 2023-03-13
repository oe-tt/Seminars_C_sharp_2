// Сортировка пузырьком (по возрастанию)
Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1, 20);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int k = 0; k < n; k++)
{   for (int i = 1; i < n; i++)
    {
        if (array[i-1] > array[i])
        {
            int temp = array[i];
            array[i] = array[i-1];
            array[i-1] = temp;
        }
    }
    for (int i = 0; i < n; i++)     Console.Write($"{array[i]} ");
Console.WriteLine();
}

    