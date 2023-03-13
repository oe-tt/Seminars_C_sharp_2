using System.Net.Sockets; // подключение библиотек для работы с протоколом TCP
using System.Net;
using System.Text;

namespace Server
{
    class OurServer
    {
        TcpListener server;

        public OurServer()
        {
            server = new TcpListener(IPAddress.Parse("127.0.0.1"), 5555);
            server.Start();

            LoopClients();
        }

        public void LoopClients()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();

                Thread thread = new Thread(() => HandleClient(client));  // создаем новый поток для каждого клиента
                thread.Start();     // запускаем поток
            }
        }

        void HandleClient(TcpClient client)
        {
            StreamReader sReader = new StreamReader(client.GetStream(), Encoding.UTF8);   // получаем поток от клиента
            StreamWriter sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);

            while (true)
            {
                string message = sReader.ReadLine();
                Console.WriteLine($"Клиент написал >> {message}");

                Console.WriteLine("Дайте сообщение клиенту: ");
                Console.Write(">> ");
                string answer = Console.ReadLine();
                sWriter.WriteLine(answer);  // получаем ответ сервера
                sWriter.Flush();            // отправляем ответ сервера на клиент
            }
        }
    }
}