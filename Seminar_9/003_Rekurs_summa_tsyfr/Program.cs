// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumNumber(int number)
{
    int sum = 0;
    if (number == 0)
    {
        return 0;
    }
    sum = number % 10 + SumNumber(number / 10);
    return sum;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
if (n < 0) n *= -1;
Console.WriteLine($"Сумма цифр числа {n} = {SumNumber(n)}");