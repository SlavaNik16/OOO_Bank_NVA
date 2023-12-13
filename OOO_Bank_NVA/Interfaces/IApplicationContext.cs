using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Models;

namespace OOO_Bank_NVA.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с контекстом
    /// </summary>
    public interface IApplicationContext
    {
        /// <summary><see cref="Person"></summary>
        DbSet<Person> Persons { get; set; }

        /// <summary><see cref="Card"></summary>
        DbSet<Card> Cards { get; set; }

        /// <summary><see cref="DBBank"></summary>
        DbSet<DBBank> DBBanks { get; set; }

        /// <summary><see cref="Basket"></summary>
        DbSet<Basket> Baskets { get; set; }

        /// <summary><see cref="Tovar"></summary>
        DbSet<Tovar> Tovars { get; set; }
    }
}
