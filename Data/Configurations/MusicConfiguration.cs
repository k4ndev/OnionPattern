using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class MusicConfiguration : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> builder)
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

            builder.HasOne(x => x.Albom)
                .WithMany(x => x.Musics)
                .HasForeignKey(x => x.AlbomId);

            builder
                .Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder
                .Property(x => x.Poster).HasMaxLength(150);

            builder
                .Property(x => x.File).IsRequired().HasMaxLength(150);

            builder
                .Property(x => x.ListeningCount).HasDefaultValue(0);

            builder
                .Property(x => x.CaDownload).IsRequired().HasDefaultValue(false);

            builder.ToTable("Musics");
        }
    }
}
