using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat.Client
{
    public partial class Form1 : Form
    {

        // Клиент
        TcpClient client;
        // Сетевой поток
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void send_Click(object sender, EventArgs e)
        {
            // Проверяем, что в текстовом поле есть сообщение
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                // Получаем сообщение из текстового поля
                string message = textBox1.Text;
                // Отправляем сообщение
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                // Очищаем текстовое поле
                textBox1.Clear();
            }
        }

        // Метод получения сообщений
        private void ReceiveMessage()
        {
            while (true)
            {
               

                    // Получаем данные
                    byte[] data = new byte[1024];
                    int bytes = stream.Read(data, 0, data.Length);
                     // Преобразуем данные в строку
                       string message = Encoding.UTF8.GetString(data, 0, bytes);
                // Добавляем сообщение в текстбокс

                textBox2.Invoke((MethodInvoker)delegate
                {
                    textBox2.AppendText(message + Environment.NewLine);
                });

            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Создаем новый экземпляр клиента
            client = new TcpClient("localhost", 5000);
            // Получаем сетевой поток для чтения/записи
            stream = client.GetStream();
            //Запускаем поток для получения сообщений
           Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start();
        }
    }
}
