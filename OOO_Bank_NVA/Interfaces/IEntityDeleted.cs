using System;

namespace OOO_Bank_NVA.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с удалением записи
    /// </summary>
    public interface IEntityDeleted
    {
        /// <summary>
        /// Дата удаления
        /// </summary>
        DateTimeOffset? DeletedAt { get; set; }
    }
}
