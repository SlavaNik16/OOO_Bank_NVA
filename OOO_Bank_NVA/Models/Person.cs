using OOO_Bank_NVA.Enums;
using System.Collections;
using System.Collections.Generic;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Сущность клиента в банке
    /// </summary>
    public class Person : BaseAuditEntity
    {
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Пол по умолчанию Мужской
        /// </summary>
        public Gender Gender { get; set; } = Gender.Male;

        internal ICollection<Operation> Operation { get; set; }
        internal ICollection<Card> Card { get; set; }
        internal ICollection<Tovar> Tovar { get; set; }

    }
}
