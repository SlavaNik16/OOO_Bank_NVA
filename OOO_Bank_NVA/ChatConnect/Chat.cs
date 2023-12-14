using Microsoft.AspNetCore.SignalR.Client;
using System;

namespace OOO_Bank_NVA.ChatConnect
{
    public class Chat
    {
        private HubConnection connection;
        public Chat()
        {
            connection = new HubConnectionBuilder()
                  .WithUrl("https://localhost:7097/chat")
            .Build();
            Connected();
        }
        public HubConnection GetConnection() => connection;
        private async void Connected()
        {
            try
            {
                await connection.StartAsync();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Чат временно недоступен!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Чат временно недоступен!");
            }
        }

        /// <summary>
        /// Метод регистрации пользователя в чате
        /// </summary>
        public async void Create(string phone)
        {
            try
            {
                await connection.InvokeAsync("Create", phone);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка регистрации пользователя в чате!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Ошибка регистрации пользователя в чате!");
            }
        }

        /// <summary>
        /// Метод обновления пользователя в чате
        /// </summary>
        public async void Update(string phone)
        {
            try
            {
                await connection.InvokeAsync("Update", phone);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка обновления пользователя в чате!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Ошибка обновления пользователя в чате!");
            }
        }

        /// <summary>
        /// Метод взятие всех сообщений отправителя и принимателя
        /// </summary>
        public async void Receive(string phoneFrom, string phoneTo)
        {
            try
            {

                await connection.InvokeAsync("Receive", phoneFrom, phoneTo);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка взятие сообщений из чата!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Ошибка взятие сообщений из чата!");
            }
        }

        /// <summary>
        /// Метод отправки сообщения
        /// </summary>
        public async void Send(string phoneFrom, string phoneTo, string message)
        {
            try
            {
                await connection.InvokeAsync("Send", phoneFrom, phoneTo, message);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ошибка! Сообщение не было отправлено", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("Ошибка! Сообщение не было отправлено!");
            }
        }
    }
}
