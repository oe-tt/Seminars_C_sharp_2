// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
void quarter(int n)
{
    if (n == 1)
    {
        Console.WriteLine("x > 0; y > 0");
    }
    else if (n == 2)
    {
        Console.WriteLine("x < 0; y > 0");
    }
    else if (n == 3)
    {
        Console.WriteLine("x < 0; y < 0");
    }
    else if (n == 4)
    {
        Console.WriteLine("x > 0; y < 0");
    }
    else
    {
        Console.WriteLine("Некорректный номер четверти");
    }
}


Console.Clear();
Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine());
quarter(num);
