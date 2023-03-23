using Agridator.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Reflection;

namespace Agridator.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Culture> Cultures => Set<Culture>();
        public DbSet<CultureCategory> CultureCategories => Set<CultureCategory>();

        public DbSet<Fertilizer> Fertilizers => Set<Fertilizer>();

        public DbSet<PlantProtectionProduct> PlantProtectionProducts => Set<PlantProtectionProduct>();

        public DbSet<UsageType> UsageTypes => Set<UsageType>();

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().Where(e => e.IsOwned()).SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Cascade;
            }



            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
            {
                throw new ArgumentNullException(nameof(optionsBuilder));
            }

            optionsBuilder
#if DEBUG
                .LogTo(Console.WriteLine, LogLevel.Warning)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
#endif
                .ConfigureWarnings(b =>
                {
#if DEBUG
                    b.Default(WarningBehavior.Throw);
                    b.Ignore(CoreEventId.SensitiveDataLoggingEnabledWarning);
#endif
                });
        }


    }
}
