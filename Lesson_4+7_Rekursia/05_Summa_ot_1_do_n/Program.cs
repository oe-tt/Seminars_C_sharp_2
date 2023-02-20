// Сумма чисел от 1 до n
Console.Clear();
int SumFor (int n)          // функция без рекурсии
{
    int result = 0;
    for (int i = 1; i<= n; i++) result +=i;
    return result;
}

int SumRecurs (int n)        // с рекурсией
{
    if (n == 0) return 0;
    else return n + SumRecurs (n - 1);
}

Console.WriteLine (SumFor(10));
Console.WriteLine (SumRecurs(20));
