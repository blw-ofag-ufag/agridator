using Agridator.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agridator.Web.Data.Configurations
{
    public class PlantProtectionProductConfiguration : IEntityTypeConfiguration<PlantProtectionProduct>
    {
        public void Configure(EntityTypeBuilder<PlantProtectionProduct> builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(x => x.Id);
        }
    }
}
