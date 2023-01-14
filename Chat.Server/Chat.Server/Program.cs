using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    class Program
    {
        // Список подключенных клиентов
        static List<TcpClient> clients = new List<TcpClient>();
        // Буфер для хранения принятых данных
        static byte[] buffer = new byte[2048];

        static void Main(string[] args)
        {
            // Запускаем сервер на порту 5000
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();

            while (true)
            {
                try
                {
                    // Принимаем новых клиентов
                    TcpClient client = listener.AcceptTcpClient();
                    // Добавляем в список нового клиента
                    clients.Add(client);

                    // Создаем новый поток для обработки подключения клиента
                    Thread thread = new Thread(new ParameterizedThreadStart(HandleClient));
                    // Запускаем поток
                    thread.Start(client);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        // Метод обработки подключения клиента
        static async void HandleClient(object obj)
        {
            // Получаем клиента
            TcpClient client = (TcpClient)obj;

            // Добавляем клиента в список
            clients.Add(client);

            // Получаем сетевой поток для чтения/записи
            NetworkStream stream = client.GetStream();

            while (true)
            {
                try
                {
                    // Читаем сообщение от клиента
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    Console.WriteLine(message);

                    // Отправляем сообщение всем клиентам
                    foreach (var c in clients)
                    {
                        NetworkStream clientStream = c.GetStream();
                        clientStream.Write(buffer, 0, bytesRead);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                  
                }
            }
        }
    }
}