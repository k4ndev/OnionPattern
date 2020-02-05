using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class AlbomConfiguration : IEntityTypeConfiguration<Albom>
    {
        public void Configure(EntityTypeBuilder<Albom> builder)
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
                .Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder
                .Property(x => x.Poster).HasMaxLength(150);
            builder
                .Property(x => x.Desc).HasMaxLength(500);
            builder
                .HasOne(x => x.Artist).WithMany(z => z.Alboms).HasForeignKey(x => x.ArtistId);


            builder
               .ToTable("Alboms");
        }
    }
}
