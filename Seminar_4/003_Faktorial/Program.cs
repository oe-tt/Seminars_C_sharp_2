// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
// Два способа записи применения одной и той же процедуры!
Console.Clear();
void Faktorial(int a)
{
    int x = 1;
    for (int i = 1; i <= a; i++)
    {
        x*= i;
    }
    Console.WriteLine($"Факториал числа {a} = {x}");
}
Console.WriteLine("Введите число");
Faktorial(int.Parse(Console.ReadLine()));

Console.WriteLine("***");
Console.WriteLine("Введите еще число");
int n = int.Parse(Console.ReadLine());
Faktorial(n);  