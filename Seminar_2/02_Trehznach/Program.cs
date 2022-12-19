// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine(number);
Console.WriteLine(number / 100 * 10 + number % 10);
