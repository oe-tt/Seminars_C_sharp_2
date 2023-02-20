// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
Console.Clear();
void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start + 1, end);
}

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
while (M > N)
{
    Console.WriteLine("Число M должно быть меньше N.");
    Console.Write("Введите M: ");
    M = int.Parse(Console.ReadLine());
    Console.Write("Введите N: ");
    N = int.Parse(Console.ReadLine());
}
PrintNumbers(M, N);