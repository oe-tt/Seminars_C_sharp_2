// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int a = int.Parse(Console.ReadLine());
if (((99 < a) & (a < 1000)) || ((-1000 < a) & (a < -99)))
{
    if (a < 0)
    {
        a *= -1;
    }
    Console.Write("Вторая цифра:");
    Console.Write((a % 100 - a % 10) / 10);
}
else
{
Console.WriteLine("Число не соответствует запрашиваемому диапазону.");
}

