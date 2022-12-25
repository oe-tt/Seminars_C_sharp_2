// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int a = int.Parse(Console.ReadLine());
if (a<0)
  {
  a = a*-1;
  }
if (a>99999)
{
  Console.WriteLine("Введено некорректное число");
}
else
{
  int a5 = a % 10;
  int a4 = a % 100 / 10;
  int a3 = a % 1000 / 100;
  int a2 = a % 10000 / 1000;
  int a1 = a / 10000;

  Console.Write(a1);
  Console.Write(a2);
  Console.Write(a3);
  Console.Write(a4);
  Console.Write(a5);

  if (a1 == a5 && a2 == a4)
  {
  Console.WriteLine(" - это палиндром");
  }
  else  
  {
  Console.WriteLine(" - это не палиндром");
  }
}
