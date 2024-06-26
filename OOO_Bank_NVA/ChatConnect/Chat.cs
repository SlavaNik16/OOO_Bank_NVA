﻿using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Windows.Forms;

namespace OOO_Bank_NVA.ChatConnect
{
    public class Chat
    {
        private HubConnection connection;
        public Chat()
        {
            connection = new HubConnectionBuilder()
                .WithUrl("https://macsimnik-001-site1.ctempurl.com/chat")
                //.WithUrl("https://localhost:7097/chat")
                .Build();
            Connected();
        }
        public HubConnection GetConnection() => connection;

        /// <summary>
        /// Подключение к чату
        /// </summary>
        private async void Connected()
        {
            try
            {
                await connection.StartAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Чат временно недоступен!");
            }
        }

        /// <summary>
        /// Метод регистрации пользователя в чате
        /// </summary>
        /// <returns>Ничего</returns>
        public async void CreateOrReplace(string phone)
        {
            try
            {
                await connection.InvokeAsync("CreateOrReplace", phone);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка создания/обновления пользователя в чате!");
            }
        }



        /// <summary>
        /// Метод взятие всех сообщений отправителя и принимателя
        /// </summary>
        /// <returns>Номер телефона отправителя, сообщение</returns>
        public async void Receive(string phoneFrom, string phoneTo)
        {
            try
            {

                await connection.InvokeAsync("Receive", phoneFrom, phoneTo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка взятие сообщений из чата!");
            }
        }

        /// <summary>
        /// Метод отправки сообщения
        /// </summary>
        /// <returns>Номер телефона отправителя, сообщение</returns>
        public async void Send(string phoneFrom, string phoneTo, string message)
        {
            try
            {
                await connection.InvokeAsync("Send", phoneFrom, phoneTo, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Сообщение не было отправлено!");
            }
        }

        /// <summary>
        /// Метод отправки уведомления о технической работе (закрытие формы через 30 сек)
        /// </summary>
        /// <returns>Ничего</returns>
        public async void SendClose()
        {
            try
            {
                await connection.InvokeAsync("SendClose");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Уведомление не было отправлено", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод отправки бана
        /// </summary>
        /// <returns>Ничего</returns>
        public async void SendBan(string phoneBan)
        {
            try
            {
                await connection.InvokeAsync("SendBan", phoneBan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка! Уведомление не было отправлено", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
