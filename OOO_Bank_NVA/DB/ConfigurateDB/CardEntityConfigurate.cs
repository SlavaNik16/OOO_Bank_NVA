using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Конфигурация сущности <see cref="Card"/>
    /// </summary>
    public class CardEntityConfigurate : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasById();
            builder.PropertyAuditConfiguration();

            builder.Property(x => x.Nomer).IsRequired().HasMaxLength(40);
            builder.Property(x => x.CSCCode).IsRequired().HasMaxLength(6);
            builder.Property(x => x.PinCode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Balance).IsRequired();

            builder.Property(x => x.DateEnd).IsRequired();

            builder.HasIndex(x => x.Nomer)
              .IsUnique()
              .HasFilter($"{nameof(Card.DeletedAt)} is null")
              .HasName($"IX_{nameof(Card)}_{nameof(Card.Nomer)}");
        }
    }
}
