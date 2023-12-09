using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Конфигурация сущности <see cref="Person"/>
    /// </summary>
    public class PersonEntityConfigurate : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasById();
            builder.PropertyAuditConfiguration();

            builder.Property(x => x.Surname).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Phone).IsRequired();

            builder.HasMany(x => x.Basket)
                 .WithOne(y => y.Person)
                 .HasForeignKey(z => z.PersonId);

            builder.HasIndex(x => x.Phone)
                .IsUnique()
                .HasFilter($"{nameof(Person.DeletedAt)} is null")
                .HasName($"IX_{nameof(Person)}_{nameof(Person.Phone)}");
        }
    }
}
