using System;

namespace OOO_Bank_NVA.Models
{
    public class Tovar : BaseAuditEntity
    {
        /// <summary>
        /// Название товара или услуги
        /// </summary>
        public string Tittle { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Кол-во
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Кто купил
        /// </summary>
        public Guid PersonId { get; set; }
        internal Person Person { get; set; }
    }
}
