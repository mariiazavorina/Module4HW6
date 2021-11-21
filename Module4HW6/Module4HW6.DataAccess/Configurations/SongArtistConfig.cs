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
    public class SongArtistConfig : IEntityTypeConfiguration<SongArtist>
    {
        public void Configure(EntityTypeBuilder<SongArtist> builder)
        {
            builder.ToTable("SongArtist").HasKey(c => c.SongArtistId);
            builder.Property(c => c.ArtistId).HasMaxLength(50).IsRequired();
            builder.Property(c => c.SongId).HasMaxLength(50).IsRequired();

            builder.HasOne(a => a.Artist)
                .WithMany(s => s.SongArtist)
                .HasForeignKey(a => a.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Song)
                .WithMany(s => s.SongArtist)
                .HasForeignKey(a => a.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new SongArtist { SongArtistId = 1, ArtistId = 1, SongId = 1 },
                new SongArtist { SongArtistId = 2, ArtistId = 3, SongId = 1 },
                new SongArtist { SongArtistId = 3, ArtistId = 1, SongId = 2 },
                new SongArtist { SongArtistId = 4, ArtistId = 2, SongId = 3 },
                new SongArtist { SongArtistId = 5, ArtistId = 5, SongId = 4 },
                new SongArtist { SongArtistId = 6, ArtistId = 6, SongId = 4 },
                new SongArtist { SongArtistId = 7, ArtistId = 4, SongId = 5 },
                new SongArtist { SongArtistId = 8, ArtistId = 4, SongId = 6 });
        }
    }
}
