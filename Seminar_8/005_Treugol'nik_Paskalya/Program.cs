// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
// Сделать вывод в виде равнобедренного треугольника пока не получилось :(
Console.Clear();
Console.Write("Введите количество строк : ");
int n = int.Parse(Console.ReadLine());


int[][] triangle = new int[n][];
triangle[0] = new int[] { 1 };          // первая строка

for (int i = 1; i < triangle.Length; i++)
{
    triangle[i] = new int[i + 1];
    for (int j = 0; j <= i; j++)
    {
        if (j == 0 || j == i)
            triangle[i][j] = 1;
        else
        {
            triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
        }
    }
}

for (int i = 0; i < triangle.Length; i++)
{
    for (int j = 0; j < triangle[i].Length; j++)
    {
        Console.Write("{0,-3} ", triangle[i][j]);      // отступы между столбцами
    }
    Console.WriteLine();
}

// Console.ReadKey();          // ожидание нажатия клавиши для продолжения работы
