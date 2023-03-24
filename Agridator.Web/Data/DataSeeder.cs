using Agridator.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Agridator.Web.Data
{
    public static class DataSeeder
    {
        public static async Task SeedDataAsync([NotNull] ApplicationDbContext db, CancellationToken cancellationToken = default)
        {
           var changed = await SeedCultureCategoriesAsync(db, false, cancellationToken).ConfigureAwait(false);
           changed = await SeedCulturesAsync(db, changed, cancellationToken).ConfigureAwait(false);
           changed = await SeedFertilizersAsync(db, changed, cancellationToken).ConfigureAwait(false);
            changed = await SeedPlantProtectionProductsAsync(db, changed, cancellationToken).ConfigureAwait(false);
            changed = await SeedTypeOfWorkAsync(db, changed, cancellationToken).ConfigureAwait(false);
            _ = await SeedUsageTypesAsync(db, changed, cancellationToken).ConfigureAwait(false);
        }

        private static async Task<bool> SeedUsageTypesAsync(ApplicationDbContext db, bool changed, CancellationToken cancellationToken = default)
        {
            //seed WogaProgram
            foreach (var i in LoadUsageTypeData())
            {
                var exist = await db.UsageTypes
                    .AsNoTracking()
                    .AnyAsync(x => x.Id == i.Id, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                if (!exist)
                {
                    db.UsageTypes.Add(i);
                    changed = true;
                }
            }

            if (changed)
            {
                await db.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                changed = false;
            }

            return changed;
        }
        private static async Task<bool> SeedTypeOfWorkAsync(ApplicationDbContext db, bool changed, CancellationToken cancellationToken = default)
        {
            //seed WogaProgram
            foreach (var i in LoadTypeOfWorkData())
            {
                var exist = await db.TypeOfWorks
                    .AsNoTracking()
                    .AnyAsync(x => x.Id == i.Id, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                if (!exist)
                {
                    db.TypeOfWorks.Add(i);
                    changed = true;
                }
            }

            if (changed)
            {
                await db.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                changed = false;
            }

            return changed;
        }

        private static async Task<bool> SeedPlantProtectionProductsAsync(ApplicationDbContext db, bool changed, CancellationToken cancellationToken = default)
        {
            //seed WogaProgram
            foreach (var i in LoadPlantProtectionProductData())
            {
                var exist = await db.PlantProtectionProducts
                    .AsNoTracking()
                    .AnyAsync(x => x.Id == i.Id, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                if (!exist)
                {
                    db.PlantProtectionProducts.Add(i);
                    changed = true;
                }
            }

            if (changed)
            {
                await db.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                changed = false;
            }

            return changed;
        }

        private static async Task<bool> SeedFertilizersAsync(ApplicationDbContext db, bool changed, CancellationToken cancellationToken = default)
        {
            //seed WogaProgram
            foreach (var i in LoadFertilizerData())
            {
                var exist = await db.Fertilizers
                    .AsNoTracking()
                    .AnyAsync(x => x.Id == i.Id, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                if (!exist)
                {
                    db.Fertilizers.Add(i);
                    changed = true;
                }
            }

            if (changed)
            {
                await db.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                changed = false;
            }

            return changed;
        }

        private static async Task<bool> SeedCulturesAsync(ApplicationDbContext db, bool changed, CancellationToken cancellationToken = default)
        {
            //seed WogaProgram
            foreach (var i in LoadCultureData())
            {
                var exist = await db.Cultures
                    .AsNoTracking()
                    .AnyAsync(x => x.Id == i.Id, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                if (!exist)
                {
                    db.Cultures.Add(i);
                    changed = true;
                }
            }

            if (changed)
            {
                await db.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                changed = false;
            }

            return changed;
        }

        private static async Task<bool> SeedCultureCategoriesAsync(ApplicationDbContext db, bool changed, CancellationToken cancellationToken = default)
        {
            //seed WogaProgram
            foreach (var category in LoadCultureCategoryData())
            {
                var exist = await db.CultureCategories
                    .AsNoTracking()
                    .AnyAsync(x => x.Id == category.Id, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                if (!exist)
                {
                    db.CultureCategories.Add(category);
                    changed = true;
                }
            }

            if (changed)
            {
                await db.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                changed = false;
            }

            return changed;
        }

        private static IEnumerable<Culture> LoadCultureData()
        {
            var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "Jsons", "Cultures.json"), Encoding.UTF8);
            return JsonConvert.DeserializeObject<IEnumerable<Culture>>(json) ?? new List<Culture>();
        }

        private static IEnumerable<CultureCategory> LoadCultureCategoryData()
        {
            var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "Jsons", "CultureCategories.json"), Encoding.UTF8);
            return JsonConvert.DeserializeObject<IEnumerable<CultureCategory>>(json) ?? new List<CultureCategory>();
        }

        private static IEnumerable<Fertilizer> LoadFertilizerData()
        {
            var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "Jsons", "Fertilizers.json"), Encoding.UTF8);
            return JsonConvert.DeserializeObject<IEnumerable<Fertilizer>>(json) ?? new List<Fertilizer>();
        }

        private static IEnumerable<PlantProtectionProduct> LoadPlantProtectionProductData()
        {
            var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "Jsons", "PlantProtectionProducts.json"), Encoding.UTF8);
            return JsonConvert.DeserializeObject<IEnumerable<PlantProtectionProduct>>(json) ?? new List<PlantProtectionProduct>();
        }

        private static IEnumerable<TypeOfWork> LoadTypeOfWorkData()
        {
            var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "Jsons", "TypeOfWork.json"), Encoding.UTF8);
            return JsonConvert.DeserializeObject<IEnumerable<TypeOfWork>>(json) ?? new List<TypeOfWork>();
        }

        private static IEnumerable<UsageType> LoadUsageTypeData()
        {
            var json = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Data", "Jsons", "UsageTypes.json"), Encoding.UTF8);
            return JsonConvert.DeserializeObject<IEnumerable<UsageType>>(json) ?? new List<UsageType>();
        }
    }
}
