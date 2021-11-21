﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Module4HW6.DataAccess;

namespace Module4HW6.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211121215836_DataAdd")]
    partial class DataAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAlive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            ArtistId = 1,
                            DateOfBirth = new DateTime(1970, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hilda@email.com",
                            InstagramUrl = "https://www.instagram.com/hilda",
                            IsAlive = true,
                            Name = "Hilda Kelly",
                            Phone = 134567890L
                        },
                        new
                        {
                            ArtistId = 2,
                            DateOfBirth = new DateTime(1940, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAlive = false,
                            Name = "Dennis Lopes",
                            Phone = 0L
                        },
                        new
                        {
                            ArtistId = 3,
                            DateOfBirth = new DateTime(1983, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "brian@email.com",
                            InstagramUrl = "https://www.instagram.com/brian",
                            IsAlive = true,
                            Name = "Brian Brown",
                            Phone = 134567890L
                        },
                        new
                        {
                            ArtistId = 4,
                            DateOfBirth = new DateTime(1924, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAlive = false,
                            Name = "Richard Diaz",
                            Phone = 0L
                        },
                        new
                        {
                            ArtistId = 5,
                            DateOfBirth = new DateTime(1999, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dora@email.com",
                            InstagramUrl = "https://www.instagram.com/dora",
                            IsAlive = true,
                            Name = "Dora Veaver",
                            Phone = 134567890L
                        },
                        new
                        {
                            ArtistId = 6,
                            DateOfBirth = new DateTime(1992, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice@email.com",
                            InstagramUrl = "https://www.instagram.com/alice",
                            IsAlive = true,
                            Name = "Alice Young",
                            Phone = 134567890L
                        });
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            Title = "Rock"
                        },
                        new
                        {
                            GenreId = 2,
                            Title = "Pop"
                        },
                        new
                        {
                            GenreId = 3,
                            Title = "Rap"
                        },
                        new
                        {
                            GenreId = 4,
                            Title = "R&B"
                        },
                        new
                        {
                            GenreId = 5,
                            Title = "Electronica"
                        });
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId");

                    b.ToTable("Song");

                    b.HasData(
                        new
                        {
                            SongId = 1,
                            Duration = 400,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1999, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sunrizze"
                        },
                        new
                        {
                            SongId = 2,
                            Duration = 360,
                            GenreId = 2,
                            ReleasedDate = new DateTime(2005, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Blue night"
                        },
                        new
                        {
                            SongId = 3,
                            Duration = 500,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1970, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Sad song"
                        },
                        new
                        {
                            SongId = 4,
                            Duration = 230,
                            ReleasedDate = new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Because I am Happy"
                        },
                        new
                        {
                            SongId = 5,
                            Duration = 348,
                            GenreId = 4,
                            ReleasedDate = new DateTime(1950, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Pride"
                        },
                        new
                        {
                            SongId = 6,
                            Duration = 124,
                            GenreId = 4,
                            ReleasedDate = new DateTime(1961, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Fearless"
                        });
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.SongArtist", b =>
                {
                    b.Property<int>("SongArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("SongArtistId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("SongArtist");

                    b.HasData(
                        new
                        {
                            SongArtistId = 1,
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            SongArtistId = 2,
                            ArtistId = 3,
                            SongId = 1
                        },
                        new
                        {
                            SongArtistId = 3,
                            ArtistId = 1,
                            SongId = 2
                        },
                        new
                        {
                            SongArtistId = 4,
                            ArtistId = 2,
                            SongId = 3
                        },
                        new
                        {
                            SongArtistId = 5,
                            ArtistId = 5,
                            SongId = 4
                        },
                        new
                        {
                            SongArtistId = 6,
                            ArtistId = 6,
                            SongId = 4
                        },
                        new
                        {
                            SongArtistId = 7,
                            ArtistId = 4,
                            SongId = 5
                        },
                        new
                        {
                            SongArtistId = 8,
                            ArtistId = 4,
                            SongId = 6
                        });
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.Song", b =>
                {
                    b.HasOne("Module4HW6.DataAccess.Entities.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.SongArtist", b =>
                {
                    b.HasOne("Module4HW6.DataAccess.Entities.Artist", "Artist")
                        .WithMany("SongArtist")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Module4HW6.DataAccess.Entities.Song", "Song")
                        .WithMany("SongArtist")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.Artist", b =>
                {
                    b.Navigation("SongArtist");
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Module4HW6.DataAccess.Entities.Song", b =>
                {
                    b.Navigation("SongArtist");
                });
#pragma warning restore 612, 618
        }
    }
}
