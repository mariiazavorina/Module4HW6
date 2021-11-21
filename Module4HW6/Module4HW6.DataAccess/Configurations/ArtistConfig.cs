using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HW6.DataAccess.Entities;

namespace Module4HW6.DataAccess.Configurations
{
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(c => c.ArtistId);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
            builder.Property(c => c.DateOfBirth).IsRequired();
            builder.HasData(
                new Artist { ArtistId = 1, Name = "Hilda Kelly", DateOfBirth = new DateTime(1970, 07, 17), IsAlive = true, Phone = 134567890, Email = "hilda@email.com", InstagramUrl = "https://www.instagram.com/hilda" },
                new Artist { ArtistId = 2, Name = "Dennis Lopes", DateOfBirth = new DateTime(1940, 04, 27), IsAlive = false },
                new Artist { ArtistId = 3, Name = "Brian Brown", DateOfBirth = new DateTime(1983, 02, 14), IsAlive = true, Phone = 134567890, Email = "brian@email.com", InstagramUrl = "https://www.instagram.com/brian" },
                new Artist { ArtistId = 4, Name = "Richard Diaz", DateOfBirth = new DateTime(1924, 12, 30), IsAlive = false },
                new Artist { ArtistId = 5, Name = "Dora Veaver", DateOfBirth = new DateTime(1999, 11, 28), IsAlive = true, Phone = 134567890, Email = "dora@email.com", InstagramUrl = "https://www.instagram.com/dora" },
                new Artist { ArtistId = 6, Name = "Alice Young", DateOfBirth = new DateTime(1992, 10, 24), IsAlive = true, Phone = 134567890, Email = "alice@email.com", InstagramUrl = "https://www.instagram.com/alice" });
        }
    }
}
