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
        /// Максимальное Кол-во
        /// </summary>
        public int MaxCount { get; set; } = 1;

        /// <summary>
        /// Описание товара
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Фото
        /// </summary>
        public string Photo { get; set; } = null;



        internal ICollection<Basket> Basket { get; set; }
    }
}
