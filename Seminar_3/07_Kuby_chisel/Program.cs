// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int i = 1;
if (N > 0)
{
    while (i <= N)
    {
        Console.Write(i * i * i + " ");
        i++;
    }
}
else
{
    while (i >= N)
    {
        Console.Write(i * i * i + " ");
        i=i-1;
    }
}