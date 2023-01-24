// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

void Koordinaty(int a, int b, int aa, int bb)
{
    if (a == aa && b == bb) Console.WriteLine("Эти прямые полностью совпадают.");
    else
    {
        if (a == aa) Console.WriteLine("Эти прямые параллельны, они никогда не пересекутся.");
        else
        {
            int x = (b - bb) / (aa - a);
            int y = a * x + b;

            Console.WriteLine($"Прямые пересекутся в точке [{x};{y}].");
        }
    }
}

Console.WriteLine("Прямая 1 задана уравнением y = k1 * x + b1.");
Console.Write("Введите значение k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.WriteLine("Прямая 2 задана уравнением y = k2 * x + b2.");
Console.Write("Введите значение k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());

Koordinaty(k1, b1, k2, b2);