// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.Write("x = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("z = ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("x = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("z = ");
int z2 = int.Parse(Console.ReadLine());
Console.Write("Расстояние между точками: ");
Console.WriteLine(Math.Sqrt(Math.Abs(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2))));
