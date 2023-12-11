using System;

namespace OOO_Bank_NVA.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с изменением записи
    /// </summary>
    public interface IEntityUpdated
    {
        /// <summary>
        /// Дата изменения
        /// </summary>
        DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Кем изменен (Фамилия пользователя)
        /// </summary>
        string UpdatedBy { get; set; }
    }

}
