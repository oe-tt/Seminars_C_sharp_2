// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.Clear();
Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a % b == 0)
{
    Console.Write (a + " кратно " + b);
}
else
{
    Console.Write (a + " не кратно " + b + ", остаток: " + (a % b));
}