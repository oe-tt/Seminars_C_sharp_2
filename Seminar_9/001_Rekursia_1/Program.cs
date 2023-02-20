// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введи значение N");

void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start + 1, end);
}

int N = int.Parse(Console.ReadLine());
while (N < 0)
{
    Console.WriteLine("Число N должно быть натуральным.");
    Console.Write("Введите N: ");
    N = int.Parse(Console.ReadLine());
}
PrintNumbers(1, N);