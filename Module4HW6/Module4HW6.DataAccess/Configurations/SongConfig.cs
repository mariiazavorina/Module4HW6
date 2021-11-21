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
    public class SongConfig : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(c => c.SongId);
            builder.Property(c => c.Title).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Duration).IsRequired();
            builder.Property(c => c.ReleasedDate).IsRequired();

            builder.HasOne(a => a.Genre)
                .WithMany(s => s.Songs)
                .HasForeignKey(a => a.GenreId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);
            builder.HasData(
                new Song { SongId = 1, Title = "Sunrizze", Duration = 400, ReleasedDate = new DateTime(1999, 07, 04), GenreId = 1 },
                new Song { SongId = 2, Title = "Blue night", Duration = 360, ReleasedDate = new DateTime(2005, 11, 12), GenreId = 2 },
                new Song { SongId = 3, Title = "Sad song", Duration = 500, ReleasedDate = new DateTime(1970, 08, 12), GenreId = 3 },
                new Song { SongId = 4, Title = "Because I am Happy", Duration = 230, ReleasedDate = new DateTime(2019, 09, 24) },
                new Song { SongId = 5, Title = "Pride", Duration = 348, ReleasedDate = new DateTime(1950, 03, 13), GenreId = 4 },
                new Song { SongId = 6, Title = "Fearless", Duration = 124, ReleasedDate = new DateTime(1961, 04, 07), GenreId = 4 });
        }   }
}
