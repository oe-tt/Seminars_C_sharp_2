//  Параллельное программирование на примере умножения матриц

// * Главный (основной) поток - тот, в котором запускается сама программа.
// * Если нет деления на потоки, то вся программа и есть - основной (единственный) поток.

Console.Clear();

const int N = 1000; //размер матрицы. Константу не изменить в программном коде
const int THREADS_NUMBER = 10; // количество потоков. Константы называются полностью большими буквами!

int[,] serialMultRes = new int[N, N]; // результат выполнения умножения матриц в однопотоке
int[,] threadMultRes = new int[N, N]; // результат параллельного умножения матриц


int[,] firstMatrix = MatrixGeneration(N, N);
int[,] secondMatrix = MatrixGeneration(N, N);

SerialMatrixMult(firstMatrix, secondMatrix);
PrepareParallelMatrixMult(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMultRes, threadMultRes));


int[,] MatrixGeneration(int rows, int colomns)    // метод для генерации матрицы случайных чисел
{
    Random _rand = new Random();
    int[,] res = new int[rows, colomns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);
        }
    }
    return res;
}

void SerialMatrixMult(int[,] a, int[,] b) // метод для серийного умножения матриц
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы"); // проверка матриц. Если матрицы не подходят, программа останавливается.
    
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMultRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

void PrepareParallelMatrixMult(int[,] a, int[,] b)  // метод для подготовки к разделению умножения матриц по потокам
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы"); // проверка матриц. Если матрицы не подходят, программа останавливается.
    int eachThreadCalc = N / THREADS_NUMBER; //подсчет, сколько вычислений будет приходиться на каждый поток
    
    Thread[] arr = new Thread[2];
    var threadsList = new List<Thread>();   //Создаем коллекцию (список) для хранения потоков. Похоже на динамический массив.
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;      // начало диапазона потока
        int endPos = (i + 1) * eachThreadCalc;  // конец диапазона потока
        // если последний поток, то:
        if (i == THREADS_NUMBER - 1) endPos = N;    // весь остаток включаем в последний поток
        threadsList.Add(new Thread(() => ParallelMatrixMult(a, b, startPos, endPos)));  // "лямбда-выражение" = "анонимная функция"
        // здесь мы активируем все потоки и каждому задаем свой диапазон

        threadsList[i].Start(); // запускаем поток
    }
    for (int i = 0; i < THREADS_NUMBER; i++)   // ждем, пока все потоки завершат работу
    {
        threadsList[i].Join(); 
    }
}

void ParallelMatrixMult(int[,] a, int[,] b, int startPos, int endPos) // метод для параллельного умножения матриц
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMultRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)     // проверка матриц
{
    bool res = true;

    for (int i = 0; i < fmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fmatrix.GetLength(1); j++)
        {
            res = res && (fmatrix[i, j] == smatrix[i, j]);
        }
    }
    return res;
}

