using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.
                  HasKey(x => x.Id);


            builder
                .Property(c => c.Id)
                .UseSqlServerIdentityColumn();

            builder
               .Property(m => m.Status)
               .IsRequired()
               .HasDefaultValue(true);


            builder
               .Property(m => m.Name)
               .IsRequired()
               .HasMaxLength(50);

            builder
                .Property(m => m.Poster)
                .HasMaxLength(150);


            builder
               .ToTable("Artists");

        }
    }
}
