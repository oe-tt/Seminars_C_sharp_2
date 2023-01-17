// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Clear();
void Colich(int a)
{
    int i = 0;
    if (a == 0) {i = 1;}
    if (a < 0)  {a *= -1;}
    int b = a;
    while (b > 0)
    {
        b = b / 10;
        i++;
    }
    Console.WriteLine($"Количество цифр в числе: {i}");
}
Console.WriteLine("Введите число");
Colich(int.Parse(Console.ReadLine()));