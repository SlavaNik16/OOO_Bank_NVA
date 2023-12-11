using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.DB.ConfigurateDB.Anchors;
using OOO_Bank_NVA.Interfaces;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.DB
{

    /// <summary>
    /// Контекст работы с БД
    /// </summary>
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
        /// Сущность Базы данных банка
        /// </summary>
        public DbSet<DBBank> DBBanks { get; set; }

        /// <summary>
        /// Сущность Карзины
        /// </summary>
        public DbSet<Basket> Baskets { get; set; }

        /// <summary>
        /// Сущность Товаров
        /// </summary>
        public DbSet<Tovar> Tovars { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        /// <summary>
        /// Регистрация всех связей в бд
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfigurateAnchors).Assembly);
        }
    }
}
