using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore;
using Agridator.Web.Data.Entities;

namespace Agridator.Web.Data.Configurations
{
    public class CultureCategoryConfiguration : IEntityTypeConfiguration<CultureCategory>
    {
        public void Configure(EntityTypeBuilder<CultureCategory> builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(x => x.Id);

            builder.OwnsOne(o => o.Description);

            builder.HasMany(x => x.Cultures).WithOne(x => x.Category).HasForeignKey(x => x.CatId);
        }
    }
}
