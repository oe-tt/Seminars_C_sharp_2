// адрес 127.0.0.1 - запрос на свой собственный комп
// (и клиент, и сервер находятся на одном компе)
// этот набор цифр работает для локального ПК всегда

using System.Net.Sockets; // подключение библиотек для работы с протоколом TCP
using System.Text;

namespace Client
{
    class OurClient
    {
        private TcpClient client;
        private StreamWriter sWriter;
        private StreamReader sReader;

        // public OurClient(string ipAddress, int portNum)
        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            sReader = new StreamReader(client.GetStream(), Encoding.UTF8);

            HandleCommunication();
        }

        void HandleCommunication()    // метод для поддержания постоянного подключения
        {
            while (true)
            {
                Console.WriteLine("Дайте сообщение серверу: ");
                Console.Write(">> ");
                string message = Console.ReadLine();    // отправляем запрос серверу
                
                sWriter.WriteLine(message);
                sWriter.Flush();

                string answerServer = sReader.ReadLine();
                Console.WriteLine($"Сервер ответил >>> {answerServer}");
            }
        }
    }
}