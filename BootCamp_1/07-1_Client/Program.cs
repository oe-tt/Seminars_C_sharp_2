// Клиент
// Console.Clear();

namespace Client   // используется для того, чтобы можно было из разных файлов обращаться одними тем же переменным
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Это наш клиент");
            OurClient ourClient = new OurClient();
        }
    }
}


