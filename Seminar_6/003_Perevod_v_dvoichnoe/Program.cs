// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();

void PrintArray(int[] array)                          // метод для вывода массива на экран
{
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число в десятичной системе счисления");
int a = int.Parse(Console.ReadLine());
int[] Array = new int[1000000];
int b = a;
int i = 0;
while (b > 1)
{
    Array [i] = b % 2;
    b = b / 2;
    i++;
}

int N = i + 1;
int[] Chislo = new int[N];
Chislo[0] = 1;
for (int j = 1; j < N; j++)
{
    Chislo[j] = Array [i-1];
    i--;
}

PrintArray(Chislo);