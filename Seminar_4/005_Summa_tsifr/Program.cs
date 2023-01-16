// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = a;
if (b < 0)  {b *= -1;}
int sum = 0;
while (b > 0)
{
    sum += b % 10;
    b = b / 10;
}
Console.WriteLine($"Сумма цифр числа {a} = {sum} ");

