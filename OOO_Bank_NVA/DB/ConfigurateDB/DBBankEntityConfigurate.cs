using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB.ConfigurateDB
{
    /// <summary>
    /// Конфигурация сущности DBBank
    /// </summary>
    public class DBBankEntityConfigurate : IEntityTypeConfiguration<DBBank>
    {
        public void Configure(EntityTypeBuilder<DBBank> builder)
        {

        }
    }
}
