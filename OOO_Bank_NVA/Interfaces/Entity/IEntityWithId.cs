using System;

namespace OOO_Bank_NVA.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с Id
    /// </summary>
    public interface IEntityWithId
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        Guid Id { get; set; }
    }
}
