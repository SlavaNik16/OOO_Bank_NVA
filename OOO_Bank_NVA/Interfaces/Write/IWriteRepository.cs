using System.Threading;

namespace OOO_Bank_NVA.Interfaces.Write
{
    /// <summary>
    /// Интерфейс создания и модификации записей в хранилище
    /// </summary>
    public interface IWriteRepository<in TEntity> where TEntity : class
    {
        /// <summary>
        /// Переопределяем функцию добавления
        /// </summary>
        void Add(TEntity entity, string nameUser);

        /// <summary>
        /// Переопределяем функцию изменения
        /// </summary>
        void Update(TEntity entity, string nameUser);

        /// <summary>
        /// Переопределяем функцию удаления
        /// </summary>
        void Delete(TEntity entity);

        /// <summary>
        /// Асинхронно сохраняет все изменения в бд
        /// </summary>
        CancellationToken SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
