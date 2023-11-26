using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Конфигурация сущности <see cref="Operation"/>
    /// </summary>
    public class OperationEntityConfigurate : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.HasById();
            builder.PropertyAuditConfiguration();

            builder.Property(x => x.PersonId).IsRequired();
            builder.Property(x => x.CardId).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.OperationType).IsRequired();

            builder.HasIndex(x => x.OperationType)
               .HasFilter($"{nameof(Operation.DeletedAt)} is null")
               .HasName($"IX_{nameof(Operation)}_{nameof(Operation.OperationType)}");
        }
    }
}
