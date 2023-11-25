using OOO_Bank_NVA.Enums;
using System;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Сущность История операций от пользователя
    /// </summary>
    public class Operation : BaseAuditEntity
    {
        /// <summary>
        /// Покупатель
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Какой картой произошла покупка
        /// </summary>
        public Guid CardId { get; set; }

        /// <summary>
        /// Используемая цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Какая операция производилась
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// Комментарий (
        /// если Перевод:указывается на какую карту и на сколько денег;
        /// eсли Покупка:название покупки и количество;
        /// )
        /// </summary>
        public string Comment { get; set; } = string.Empty;
    }
}
