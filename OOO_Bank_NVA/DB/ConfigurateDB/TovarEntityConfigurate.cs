using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Конфигурация сущности <see cref="Tovar"/>
    /// </summary>
    public class TovarEntityConfigurate : IEntityTypeConfiguration<Tovar>
    {
        public void Configure(EntityTypeBuilder<Tovar> builder)
        {
            builder.HasById();
            builder.PropertyAuditConfiguration();

            builder.Property(x => x.Tittle).IsRequired().HasMaxLength(120);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Count).IsRequired();

            builder.HasIndex(x => x.Tittle)
                .IsUnique()
                .HasFilter($"{nameof(Tovar.DeletedAt)} is null")
                .HasName($"IX_{nameof(Tovar)}_{nameof(Tovar.Tittle)}");
        }
    }
}
