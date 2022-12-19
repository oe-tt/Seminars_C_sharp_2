// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Clear();
int number = new Random().Next(10,100);
Console.WriteLine(number);
if (number / 10 > number % 10)
{
    Console.WriteLine (number / 10);
}
else 
{
    Console.WriteLine (number % 10);
}
