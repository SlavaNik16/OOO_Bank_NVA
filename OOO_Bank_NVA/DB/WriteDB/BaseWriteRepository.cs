using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.Interfaces;
using OOO_Bank_NVA.Interfaces.Write;
using System;
using System.Threading;

namespace OOO_Bank_NVA.DB
{
    public class BaseWriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : class, IEntity
    {
        private DbContextOptions<ApplicationContext> options;
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        public CancellationToken cancellationToken;
        public BaseWriteRepository()
        {
            options = DataBaseHelper.Options();
            cancellationToken = cancellationTokenSource.Token;
        }
        public void Add(TEntity entity, string nameUser = "Анонимный")
        {
            if (entity is IEntityWithId entityWithId
                 && entityWithId.Id == Guid.Empty)
            {
                entityWithId.Id = Guid.NewGuid();
            }
            AuditForCreated(entity, nameUser);
            AuditForUpdated(entity, nameUser);
            using (var db = new ApplicationContext(options))
            {
                Console.WriteLine(db.GetHashCode());
                db.Add(entity);
                db.SaveChanges();
            }
         }
            
        public void Update(TEntity entity, string nameUser = "Анонимный")
        {
            AuditForUpdated(entity, nameUser);
            using (var db = new ApplicationContext(options))
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            AuditForDeleted(entity);
            using (var db = new ApplicationContext(options))
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }

        public void AuditForCreated(TEntity entity, string nameUser)
        {
            if(entity is IEntityCreated entityCreated)
            {
                entityCreated.CreatedAt = DateTimeOffset.UtcNow;
                entityCreated.CreatedBy = nameUser;
            }
        }

        public void AuditForUpdated(TEntity entity, string nameUser)
        {
            if (entity is IEntityUpdated entityUpdated)
            {
                entityUpdated.UpdatedAt = DateTimeOffset.UtcNow;
                entityUpdated.UpdatedBy = nameUser;
            }
        }
        public void AuditForDeleted(TEntity entity)
        {
            if (entity is IEntityDeleted entityDeleted)
            {
                entityDeleted.DeletedAt = DateTimeOffset.UtcNow;
            }
        }
    }
}
