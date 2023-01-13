// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// Вариант 1 - последовательный:
/* 
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= a; i++)
{
    sum += i;
}
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}"); */


// Вариант 2 - с функцией:

Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int Summa(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}
Summa (a);
Console.WriteLine($"Сумма чисел от 1 до {a} = {Summa(a)}");


// Вариант 3 - с процедурой:

Console.WriteLine("***");
Console.WriteLine("Введите еще число");
int b = int.Parse(Console.ReadLine());
void Summa2(int b)
{
    int sum2 = 0;
    for (int i = 0; i <= b; i++)
    {
        sum2 += i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {b} = {sum2}");    
}
Summa2(b);




// Вариант преподавателя:
/* 
void GetSumNums(int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)
    {
        sum += i;
    } 
    Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");

}

Console.Clear();

GetSumNums(-5);
GetSumNums(58);
GetSumNums(25);
GetSumNums(16);

Console.WriteLine("Введите число A");
int n = Convert.ToInt32(Console.ReadLine());        // берется значение числа по модулю, через ввод в переменную
GetSumNums(n);

Console.WriteLine("Введите число A");
GetSumNums(Convert.ToInt32(Console.ReadLine()));       // через ввод напрямую
 */

