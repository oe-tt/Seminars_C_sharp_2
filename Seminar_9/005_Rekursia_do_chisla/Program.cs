//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// 
Console.Clear();

void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start -1, end);
}

Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
while (N < 0)
{
    Console.WriteLine("Число N должно быть натуральным.");
    Console.Write("Введите N: ");
    N = int.Parse(Console.ReadLine());
}
PrintNumbers(N, 1);
