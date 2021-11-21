using System;
using Microsoft.EntityFrameworkCore;
using Module4HW6.DataAccess.Entities;
using Module4HW6.DataAccess.Configurations;

namespace Module4HW6.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Song> Song { get; set; }
        public DbSet<SongArtist> SongArtist { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new SongConfig());
            modelBuilder.ApplyConfiguration(new SongArtistConfig());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.LogTo(Console.Write);
        }
    }
}
