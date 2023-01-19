// Факториал
Console.Clear();

double Factorial(int n)
{
    if (n == 1) return 1;     // !1 = 1       // !0 = 1
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(3));    // 1*2*3=6

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"!{i} = {Factorial(i)}");
// }

// После !16 идут отрицательные числа из-за переполнения типа

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"!{i} = {Factorial(i)}");
}