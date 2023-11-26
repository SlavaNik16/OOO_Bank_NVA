using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OOO_Bank_NVA.DB
{
    public static class DataBaseHelper
    {
        /// <summary>
        /// Метод получения options для работы с бд
        /// </summary>
        public static DbContextOptions<ApplicationContext> Options()
        {
            var builderConfig = new ConfigurationBuilder();
            builderConfig.SetBasePath(Directory.GetCurrentDirectory());
            builderConfig.AddJsonFile("appsettings.json");
            var config = builderConfig.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            return builder
                    .UseSqlServer(connectionString)
                    .Options;
        }
    }
}
