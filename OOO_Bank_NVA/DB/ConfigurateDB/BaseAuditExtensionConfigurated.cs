using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOO_Bank_NVA.Interfaces;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Методы расширения для <see cref="EntityTypeBuilder"/>
    /// </summary>
    internal static class BaseAuditExtensionConfigurated
    {
        /// <summary>
        /// Задаёт конфигурацию свойств аудита для сущности <inheritdoc cref="BaseAuditEntity"/>
        /// </summary>
        public static void PropertyAuditConfiguration<TEntity>(this EntityTypeBuilder<TEntity> entityBuilder)
            where TEntity : BaseAuditEntity
        {
            entityBuilder.Property(x => x.CreatedAt).IsRequired();
            entityBuilder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(200);
            entityBuilder.Property(x => x.UpdatedAt).IsRequired();
            entityBuilder.Property(x => x.UpdatedBy).IsRequired().HasMaxLength(200);
        }
        /// <summary>
        /// Задаёт конфигурацию ключа для идентификатора <see cref="IEntityWithId.Id"/>
        /// </summary>
        public static void HasById<TEntity>(this EntityTypeBuilder<TEntity> builder)
            where TEntity : class, IEntityWithId
            => builder.HasKey(x => x.Id);

    }
}
