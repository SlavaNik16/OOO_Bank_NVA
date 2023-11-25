using System;

namespace OOO_Bank_NVA.Models
{
    /// <summary>
    /// Класс общего поведения
    /// </summary>
    public abstract class BaseAuditEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Кем создан (Фамилия пользователя)
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Кем изменен (Фамилия пользователя)
        /// </summary>
        public string UpdatedBy { get; set; } = string.Empty;

        /// <summary>
        /// Дата удаления
        /// </summary>
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
