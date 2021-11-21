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
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(c => c.GenreId);
            builder.Property(c => c.Title).HasMaxLength(50).IsRequired();

            builder.HasData(
                new Genre { GenreId = 1, Title = "Rock" },
                new Genre { GenreId = 2, Title = "Pop" },
                new Genre { GenreId = 3, Title = "Rap" },
                new Genre { GenreId = 4, Title = "R&B" },
                new Genre { GenreId = 5, Title = "Electronica" });
        }
    }
}
