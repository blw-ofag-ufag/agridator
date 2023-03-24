using Agridator.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Agridator.Web.Data.Configurations
{
    public class TypeOfWorkConfiguration : IEntityTypeConfiguration<TypeOfWork>
    {
        public void Configure(EntityTypeBuilder<TypeOfWork> builder)
        {
            if (builder is null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.HasKey(x => x.Id);

            builder.OwnsOne(o => o.Title);
        }
    }
}
