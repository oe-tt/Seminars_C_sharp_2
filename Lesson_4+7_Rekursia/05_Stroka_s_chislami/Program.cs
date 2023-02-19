// Собрать строку с числами от a до b
Console.Clear();
string NumbersFor(int a, int b)                 // метод без рекурсии
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecurs1 (int a, int b)            // метод с рекурсией изначальный
{
    Console.Write("* ");                        // подсчет количества вызовов функции
    if (a <= b) return $"{a} " + NumbersRecurs1 (a + 1, b);
    else return string.Empty;
}

string NumbersRecurs2(int a, int b)             // метод с рекурсией 2: на один вызов рекурсии меньше
{
    Console.Write("* ");
    if (a <= b) 
    {
        while (a < b) return $"{a} " + NumbersRecurs2(a + 1, b);
        return $"{a} ";
    }
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRecurs1(1, 10));
Console.WriteLine(NumbersRecurs2(1, 10));