using System;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Сущность карты на котором хранятся средства
    /// </summary>
    public class Card : BaseAuditEntity
    {
        /// <summary>
        /// Номер карты
        /// </summary>
        public string Nomer { get; set; }

        /// <summary>
        /// CSC код
        /// </summary>
        public int CSCCode { get; set; }

        /// <summary>
        /// Дата oкончания
        /// </summary>
        public DateTime DateEnd{ get; set; }

        /// <summary>
        /// Баланс карты
        /// </summary>
        public decimal Balance { get; set; } = 0;

        /// <summary>
        /// Пин код
        /// </summary>
        public string PinCode { get; set; } = string.Empty;
    }
}
