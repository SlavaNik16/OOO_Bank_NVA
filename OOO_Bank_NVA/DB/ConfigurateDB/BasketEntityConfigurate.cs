using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Конфигурация сущности <see cref="Basket"/>
    /// </summary>
    public class BasketEntityConfigurate : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasById();
            builder.PropertyAuditConfiguration();

            builder.Property(x => x.PersonId).IsRequired();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(120);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Count).IsRequired();
        }
    }
}
