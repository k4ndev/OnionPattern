using Core.Models;
using Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MusicAppContext :DbContext
    {
        public MusicAppContext(DbContextOptions<MusicAppContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MusicConfiguration());
            builder.ApplyConfiguration(new AlbomConfiguration());
            builder.ApplyConfiguration(new ArtistConfiguration());
        }

        public DbSet<Music> Musics { get; set; }
        public DbSet<Albom> Alboms { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
