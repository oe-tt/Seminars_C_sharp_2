// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// №1. Линейная программа.

/* Console.Clear();
Console.WriteLine("Введите число, которое возводим в степень:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно вовзвести число:");
int b = int.Parse(Console.ReadLine());
double c = 1;
if (b >= 0)
{
    if (b > 0)
    {
        for (int i = 1; i <= b; i++)
        {
            c *= a;
        }
    }
    Console.WriteLine($"Число {a} в степени {b} = {c}");
}
if (b < 0)
{
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        c *= a;
    }
    Console.WriteLine($"Число {a} в степени {b} = 1/{c} = {1 / c}");
} */

// №2. Использование функции

/* Console.WriteLine("***");
Console.WriteLine("А теперь с использованием функции."); */
/* Console.Clear();
Console.WriteLine("Введите число, которое возводим в степень:");
int aa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно вовзвести число:");
int bb = int.Parse(Console.ReadLine());
int cc = 1;
int Stepen(int aa, int bb)
{
    for (int i = 1; i <= Math.Abs(bb); i++)
    {
        cc *= aa;
    }
    return cc;
}
double rez = 1;
if (bb >= 0)
{
    if (bb > 0)
    {
        rez = Stepen(aa, bb);
    }
    Console.WriteLine($"Число {aa} в степени {bb} = {rez}");
}
else
{
    rez = Stepen(aa, bb);
    Console.WriteLine($"Число {aa} в степени {bb} = 1/{rez} = {1 / rez}");
} */



// №3. Использование вложенных методов

Console.Clear();
Console.WriteLine("Введите число, которое возводим в степень:");
int aa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно вовзвести число:");
int bb = int.Parse(Console.ReadLine());
int cc = 1;

int Stepen(int aa, int bb)
{
    for (int i = 1; i <= Math.Abs(bb); i++)
    {
        cc *= aa;
    }
    return cc;
}

void Polojit(int aa, int bb)
{
    double rez = Stepen(aa, bb);
    Console.WriteLine($"Число {aa} в степени {bb} = {rez}");
}

void Otritsat(int aa, int bb)
{
    double rez = Stepen(aa, bb);
    Console.WriteLine($"Число {aa} в степени {bb} = 1/{rez} = {1 / rez}");
}

if (bb == 0)    { Console.WriteLine($"Число {aa} в степени {bb} = 1"); }
if (bb > 0)     { Polojit(aa, bb); }
if (bb < 0)     { Otritsat(aa, bb); }




// №2-1. Использование функции, только для положительной степени

// Console.WriteLine("***");
// Console.WriteLine("А теперь с использованием функции.");
// Console.WriteLine("Введите число, которое возводим в степень:");
// int aa = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите степень, в которую нужно вовзвести число:");
// int bb = int.Parse(Console.ReadLine());
// int cc = 1;
// int Stepen(int aa, int bb)
// {
//     for (int i = 1; i <= bb; i++)
//     {
//         cc *= aa;
//     }
//     return cc;
// }
// int rez = Stepen(aa, bb);
// Console.WriteLine($"Число {aa} в степени {bb} = {rez}");



// №1-1. Первая версия - только с положительной степенью

/* Console.Clear();
Console.WriteLine("Введите число, которое возводим в степень:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень, в которую нужно вовзвести число:");
int b = int.Parse(Console.ReadLine());
int c = 1;
for (int i = 1; i <= b; i++)
{
    c *= a;
}
Console.WriteLine($"Число {a} в степени {b} = {c}"); */