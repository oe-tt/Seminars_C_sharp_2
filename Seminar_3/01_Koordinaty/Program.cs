// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Quoter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка находится в 1-й четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Точка находится во 2-й четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Точка находится в 3-й четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка находится в 4-й четверти");
    }
    else
    {
        Console.WriteLine("Четверть не определить");
    }
}


Console.Clear();
Console.WriteLine("Введите координаты");
int coordX = int.Parse(Console.ReadLine());
int coordY = int.Parse(Console.ReadLine());
Quoter(coordX,coordY);
Quoter(15,-20);