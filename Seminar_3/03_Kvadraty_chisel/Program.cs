// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
// int i = 1;
// while (i <= N)
// {
//     Console.Write (i*i + " ");
//     i++;
// }
for (int i = 1 ; i <= N ; i++)
{
    Console.Write($"{i*i} ");
}