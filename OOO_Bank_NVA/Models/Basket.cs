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
        /// Какой товар
        /// </summary>
        public Guid TovarId { get; set; }
        internal Tovar Tovar { get; set; }

        /// <summary>
        /// Кол-во данного товара
        /// </summary>
        public int Count { get; set; } = 1;

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
