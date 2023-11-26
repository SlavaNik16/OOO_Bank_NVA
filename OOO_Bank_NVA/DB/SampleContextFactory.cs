using Microsoft.EntityFrameworkCore.Design;

namespace OOO_Bank_NVA.DB
{

    /// <summary>
    /// Файбрика для создания контекста в DesignTime (Миграции)
    /// </summary>
    public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
            => new ApplicationContext(DataBaseHelper.Options());
    }
}
