using OOO_Bank_NVA.Models.Enums;
using System;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Сущность корзины покупателя
    /// </summary>
    public class Basket : BaseAuditEntity
    {

        /// <summary>
        /// Название товара или услуги
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Цена за 1
        /// </summary>
        public decimal Price { get; set; } = 0;

        /// <summary>
        /// Кол-во данного товара
        /// </summary>
        public int Count { get; set; } = 1;

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Фото
        /// </summary>
        public string Photo { get; set; } = string.Empty;

        /// <summary>
        /// Кому принадлежит
        /// </summary>
        public Guid PersonId { get; set; }
        internal Person Person { get; set; }

        // <summary>
        /// Статус оплаты
        /// </summary>
        public StatusBy StatusBy { get; set; } = StatusBy.Attendant;
    }
}
