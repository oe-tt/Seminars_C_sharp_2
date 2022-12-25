// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними на плоскости.
Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.Write("x = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("x = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y2 = int.Parse(Console.ReadLine());
// Console.WriteLine(Math.Pow((x2-x1),2));
// Console.WriteLine(Math.Pow((y2-y1),2));
// Console.WriteLine(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
Console.Write("Расстояние между точками:");
Console.WriteLine(Math.Sqrt(Math.Abs(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2))));
