using System;

namespace OOO_Bank_NVA.ModelsResponce
{
    /// <summary>
    /// Класс вывода пользователей
    /// </summary>
    public class UserResponce
    {

        /// <summary>
        /// Телефон
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер карты
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Статус
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Права
        /// </summary>
        public string Role { get; set; }
    }
}
