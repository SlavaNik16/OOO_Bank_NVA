using OOO_Bank_NVA.Enums;
using OOO_Bank_NVA.Interfaces;
using OOO_Bank_NVA.Models;
using OOO_Bank_NVA.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace OOO_Bank_NVA.DB.ReadDB
{
    /// <summary>
    /// Общие спецификации чтения
    /// </summary>
    public static class CommonSpec
    {
        /// <summary>
        /// По телефону проверить зарегистрирован ли ?
        /// </summary>
        public static bool IsPhoneWithLogin<TEntity>(this IQueryable<TEntity> query, string phone) where TEntity : DBBank
            => query.Any(x => x.Login == phone);

        /// <summary>
        /// По номеру карты проверить есть ли?
        /// </summary>
        public static bool IsCardWithPerson<TEntity>(this IQueryable<TEntity> query, string numberPerson) where TEntity : Card
            => query.Any(x => x.Nomer == numberPerson);

        /// <summary>
        /// По идентификатору 
        /// </summary>
        public static TEntity ById<TEntity>(this IQueryable<TEntity> query, Guid id) where TEntity : class, IEntityWithId
            => query.FirstOrDefault(x => x.Id == id);

        /// <summary>
        /// По идентификаторам
        /// </summary>
        public static IQueryable<TEntity> ByIds<TEntity>(this IQueryable<TEntity> query, IEnumerable<Guid> ids) where TEntity : class, IEntityWithId
        {
            var cnt = ids.Count();
            switch (cnt)
            {
                case 0:
                    return query.Where(x => false);
                default:
                    return query.Where(x => ids.Contains(x.Id));
            }
        }

        /// <summary>
        /// Не удаленные записи
        /// </summary>
        public static IQueryable<TEntity> NotDeletedAt<TEntity>(this IQueryable<TEntity> query) where TEntity : class, IEntityDeleted
            => query.Where(x => x.DeletedAt == null);

        /// <summary>
        /// По роли
        /// </summary>
        public static IQueryable<TEntity> ByRole<TEntity>(this IQueryable<TEntity> query, RoleType roleType) where TEntity : DBBank
            => query.Where(x => x.Role == roleType);

        /// <summary>
        /// По статусу не забаненный
        /// </summary>
        public static IQueryable<TEntity> NotBlockedStatus<TEntity>(this IQueryable<TEntity> query) where TEntity : DBBank
            => query.Where(x => x.Status != StatusType.Blocked);

        /// <summary>
        /// Авторизация
        /// </summary>
        public static TEntity Authorization<TEntity>(this IQueryable<TEntity> query, string login, string password) where TEntity : DBBank
            => query.FirstOrDefault(x => x.Login.StartsWith(login) && x.Password == getHashSha256(password));

        public static string getHashSha256(string text)
        {
            using (SHA256 hashString = SHA256.Create())
            {
                byte[] bytes = Encoding.Unicode.GetBytes(text);
                byte[] hash = hashString.ComputeHash(bytes);
                string hashstring = "";
                foreach (byte x in hash)
                {
                    hashstring += String.Format("{0:x2}", x);
                }
                return hashstring;
            }
        }
    }
}
