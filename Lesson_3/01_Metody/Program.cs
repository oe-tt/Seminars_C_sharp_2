Console.Clear();
// Vid 1 - ничего не принимает, ничего не возвращает

void Metod1()
{
    Console.WriteLine("1. Данный метод ничего не принимает и ничего не возвращает, в этом примере - только выводит на экран.");
}
Metod1();


// Vid 2-1 - что-то принимает, но ничего не возвращает
void Metod2_1 (string MyText)
{
    Console.WriteLine(MyText);
}
Metod2_1("2_1. Данный метод принимает какие-то данные, например, текст сообщения, но ничего не возвращает.");


// Vid 2-2 - тот же метод, но с дополнительными параметрами
void Metod2_2 (string MyText, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(MyText);
        i++;
    }
    
}
Metod2_2("2_2. Текст, а далее - количество его повторов (например, 4).", 4);
Console.WriteLine("Теперь введите сами число повторов");
int a = int.Parse(Console.ReadLine());
Metod2_2("2_2. Текст, а далее - количество его повторов.", a); // Здесь число повторов водится уже в процессе выполнения программы.
Metod2_2(MyText: "2_2+. Текст с названием аргументов. Здесь их 2", count: 2); // То же самое, но с более явным указанием именования аргументов, где текст, а где количество. Работает так же.
Metod2_2(count: 3, MyText: "2_2++. Если используются ИМЕНОВАННЫЕ аргументы, то можно их писать в любом порядке!");


// Vid 3 - ничего не принимает, но что-то возвращает
int Metod3()
{
    return DateTime.Now.Year;   // возвращает текущий год
}
int year = Metod3();            // записываем в переменную year результат работы метода
Console.WriteLine(year);


// Vid 4 - что-то принимает и что-то возвращает
string Metod4(int count, string text)
{
    int i = 0;
    string rezultat = String.Empty;

    while (i < count)
    {
        rezultat = rezultat + text;
        i++;
    }
    return rezultat;
}

string rez = Metod4(6, "Текст для повтора ");     // Указываем количество повторов (то самое i в Методе) и текст, который будем повторять
Console.WriteLine (rez);


// Vid 4-2 - тот же метод, но с другим циклом!
// Цикл FOR
string Metod4_2(int count, string text)
{
    string rezultat = String.Empty;

    for (int i = 0; i < count; i++)
    {
        rezultat = rezultat + text;
    }
    return rezultat;
}
string rezul = Metod4_2(5, "Еще текст для цикла ");     // Указываем количество повторов (то самое i в Методе) и текст, который будем повторять
Console.WriteLine (rezul);

