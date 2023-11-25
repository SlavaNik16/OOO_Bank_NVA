using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Interfaces;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        /// <summary>
        /// Сущность персоны
        /// </summary>
        public DbSet<Person> Persons { get; set; }

        /// <summary>
        /// Сущность Карты
        /// </summary>
        public DbSet<Card> Cards { get; set; }

        /// <summary>
        /// Сущность Операций
        /// </summary>
        public DbSet<Operation> Operations { get; set; }

        /// <summary>
        /// Сущность Базы данных банка
        /// </summary>
        public DbSet<DBBank> DBBanks { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
