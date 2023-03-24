using Agridator.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agridator.Web.Data.Configurations
{
    public class UsageTypeConfiguration : IEntityTypeConfiguration<UsageType>
    {
        public void Configure(EntityTypeBuilder<UsageType> builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(x => x.Code);

            builder.OwnsOne(o => o.Nutzung);
        }
    }
}
