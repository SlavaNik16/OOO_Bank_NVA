using System;

namespace OOO_Bank_NVA.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с созданием записи
    /// </summary>
    public interface IEntityCreated
    {
        /// <summary>
        /// Дата создания
        /// </summary>
        DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// Кем создан (Фамилия пользователя)
        /// </summary>
        string CreatedBy { get; set; }
    }
}
