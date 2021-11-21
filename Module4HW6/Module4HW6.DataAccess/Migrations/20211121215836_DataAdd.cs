using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Module4HW6.DataAccess.Migrations
{
    public partial class DataAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "ArtistId", "DateOfBirth", "Email", "InstagramUrl", "IsAlive", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1970, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hilda@email.com", "https://www.instagram.com/hilda", true, "Hilda Kelly", 134567890L },
                    { 2, new DateTime(1940, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, "Dennis Lopes", 0L },
                    { 3, new DateTime(1983, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "brian@email.com", "https://www.instagram.com/brian", true, "Brian Brown", 134567890L },
                    { 4, new DateTime(1924, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, "Richard Diaz", 0L },
                    { 5, new DateTime(1999, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "dora@email.com", "https://www.instagram.com/dora", true, "Dora Veaver", 134567890L },
                    { 6, new DateTime(1992, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice@email.com", "https://www.instagram.com/alice", true, "Alice Young", 134567890L }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Title" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Pop" },
                    { 3, "Rap" },
                    { 4, "R&B" },
                    { 5, "Electronica" }
                });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[] { 4, 230, null, new DateTime(2019, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Because I am Happy" });

            migrationBuilder.InsertData(
                table: "Song",
                columns: new[] { "SongId", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, 400, 1, new DateTime(1999, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunrizze" },
                    { 2, 360, 2, new DateTime(2005, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blue night" },
                    { 3, 500, 3, new DateTime(1970, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sad song" },
                    { 5, 348, 4, new DateTime(1950, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pride" },
                    { 6, 124, 4, new DateTime(1961, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fearless" }
                });

            migrationBuilder.InsertData(
                table: "SongArtist",
                columns: new[] { "SongArtistId", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 5, 5, 4 },
                    { 6, 6, 4 }
                });

            migrationBuilder.InsertData(
                table: "SongArtist",
                columns: new[] { "SongArtistId", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 3 },
                    { 7, 4, 5 },
                    { 8, 4, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SongArtist",
                keyColumn: "SongArtistId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "ArtistId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Song",
                keyColumn: "SongId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 4);
        }
    }
}
