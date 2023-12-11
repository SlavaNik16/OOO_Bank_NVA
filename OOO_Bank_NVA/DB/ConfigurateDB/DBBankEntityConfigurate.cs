using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Конфигурация сущности <see cref="DBBank"/>
    /// </summary>
    public class DBBankEntityConfigurate : IEntityTypeConfiguration<DBBank>
    {
        public void Configure(EntityTypeBuilder<DBBank> builder)
        {
            builder.HasById();
            builder.PropertyAuditConfiguration();

            builder.Property(x => x.Login).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasIndex(x => x.Login)
              .IsUnique()
              .HasFilter($"{nameof(DBBank.DeletedAt)} is null")
              .HasName($"IX_{nameof(DBBank)}_{nameof(DBBank.Login)}");

            builder.HasIndex(x => x.Status)
             .HasFilter($"{nameof(DBBank.DeletedAt)} is null")
             .HasName($"IX_{nameof(DBBank)}_{nameof(DBBank.Status)}");
        }
    }
}
