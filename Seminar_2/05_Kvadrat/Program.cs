// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.Clear();
Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a*a == b || b*b == a)
{
    Console.WriteLine ("yes");
}
else
{
    Console.WriteLine ("no");
}