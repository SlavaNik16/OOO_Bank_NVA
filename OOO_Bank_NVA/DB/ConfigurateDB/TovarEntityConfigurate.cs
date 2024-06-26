﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOO_Bank_NVA.Models;

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

            builder.Property(x => x.Title).IsRequired().HasMaxLength(120);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.MaxCount).IsRequired();

            builder.HasIndex(x => x.Title)
                .IsUnique()
                .HasFilter($"{nameof(Tovar.DeletedAt)} is null")
                .HasName($"IX_{nameof(Tovar)}_{nameof(Tovar.Title)}");
        }
    }
}
