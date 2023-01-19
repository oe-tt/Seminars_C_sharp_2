// Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.Clear();

void PrintArray(int[] array)                          // метод для вывода массива на экран
{
    int N = array.Length;
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Proverka(int [] array)
{
    if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[1] + array[0]) return 1;
    else return 0;
}

void PrintVyvod(int vyv)
{
    if (vyv == 1) Console.WriteLine("Такой треугольник может существовать.");
    else Console.WriteLine("Такой треугольник существовать не может.");
}

int[] DlinyStoron = new int [3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите длину стороны треугольника:");
    DlinyStoron[i] = int.Parse(Console.ReadLine());
}

PrintArray(DlinyStoron);
int Vyvod = Proverka(DlinyStoron);
PrintVyvod(Vyvod);