// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a < 0)
{
    a = a * -1;
}
if (a < 100)
{
    Console.WriteLine("Тетьей цифры нет");
}
else
{
    if (a < 1000)
    {
        Console.Write("Третья цифра числа: ");
        Console.Write(a % 10);
    }
    else
    {
        int b = a;
        int c = a;
        int i = 1;
        while (b / 10 > 0)
        {
            b = b / 10;
            i++;
        }
        Console.WriteLine("Количество цифр в числе: " + i);
        while (i > 2)
        {
            c = a % 10;
            a = a / 10;
            i--;
        }
        Console.Write("Третья цифра числа: " + c);
    }
}