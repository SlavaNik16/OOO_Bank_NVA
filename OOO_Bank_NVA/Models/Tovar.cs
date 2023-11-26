using System.Collections.Generic;

namespace OOO_Bank_NVA.Models
{
    public class Tovar : BaseAuditEntity
    {
        /// <summary>
        /// Название товара или услуги
        /// </summary>
        public string Tittle { get; set; }

        /// <summary>
        /// Цена за 1
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Кол-во
        /// </summary>
        public int Count { get; set; }

        internal ICollection<Basket> Basket { get; set; }
    }
}
