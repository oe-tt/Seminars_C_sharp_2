// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
int SumRecurs(int m, int n) 
{
    if (m == n) return m;
    else return m + SumRecurs(m + 1, n);
}
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
while (m > n)
{
    Console.WriteLine("Число m должно быть меньше n.");
    Console.Write("Введите m: ");
    m = int.Parse(Console.ReadLine());
    Console.Write("Введите n: ");
    n = int.Parse(Console.ReadLine());
}
Console.Write($"Сумма чисел от {m} до {n} = ");
Console.WriteLine(SumRecurs(m, n));