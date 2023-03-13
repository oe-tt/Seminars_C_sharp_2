// Дано число N. Нужно показать от -N до N.
Console.Clear();            // Без методов программы вообще не писать!
int GetNumbers1()           // Метод 1 для получения числа от пользователя 
{
    int n = 0;
    while (n <= 0)
    {
        Console.Write("Введите число N>0 : ");
        n = int.Parse(Console.ReadLine()!);
    }
    return n;
}

int GetNumbers2(string text) // Метод 2 для получения числа с проверкой числа (защита от ввода не числа)
{
    int n = 0;
    bool flag = false;
    do
    {
        Console.Write(text);
        string s = Console.ReadLine()!;
        flag = int.TryParse(s, out n) && n > 0;
    } while (!flag);
    return n;
}

void PrintNumbers1(int n)  // Метод 1 - плохой, нельзя выводить метод в консоль!
{
    for (int i = -n; i <= n; i++)
    {
        Console.Write($"{i} ");
    }
}

string PrintNumbers2(int n)  // Метод 2 - более универсальный, но плохой, слишком много проходов по циклу для заполнения строки!
{
    string output = String.Empty; // output - просто имя переменной для данных на вывод
    for (int i = -n; i <= n; i++)
    {
        output = output + $"{i} ";
    }
    return output;
}

string PrintNumbers3(int n)  // Метод 3 - более эффективный, т.к. меньше повтров цикла. Но тогда дублируется 0
{
    string output = String.Empty; // output - просто имя переменной для данных на вывод
    for (int i = 0; i <= n; i++)
    {
        output = $"{-i} " + output + $"{i} ";
    }
    return output;
}

string PrintNumbers4(int n)  // Метод 3 - более эффективный, т.к. меньше повтров цикла. Но тогда дублируется 0
{
    string output = "0"; // output - просто имя переменной для данных на вывод
    for (int i = 1; i <= n; i++)
    {
        output = $"{-i} " + output + $" {i}";
    }
    return output;
}

// int N = GetNumbers1();
int N = GetNumbers2("Введите число N>0 : ");
// PrintNumbers1(N);
// Console.WriteLine(PrintNumbers3(N));
Console.WriteLine(PrintNumbers4(N));
File.WriteAllText("data.txt", PrintNumbers2(N));