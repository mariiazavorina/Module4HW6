using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Module4HW6.DataAccess;

namespace Module4HW6
{
    public class Starter
    {
        public void Run()
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = configuration.GetConnectionString("Module4HW6");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));
            var applicationContext = new ApplicationContext(dbOptionsBuilder.Options);

            var songs = applicationContext.Song
                    .Include(i => i.SongArtist)
                        .ThenInclude(i => i.Artist)
                    .Include(i => i.Genre)
                    .Where(i => i.Genre != null)
                    .Where(i => i.SongArtist.Select(a => a.Artist.IsAlive).Contains(true))
                    .Select(i => new { Title = i.Title, Artists = i.SongArtist.Select(a => a.Artist.Name), Genre = i.Genre.Title })
                    .ToList();

            Console.WriteLine("Task 1:");
            foreach (var song in songs)
            {
                Console.WriteLine($"Title: {song.Title}, Genre: {song.Genre}");
                Console.Write("Artists: ");
                foreach (var artist in song.Artists)
                {
                    Console.Write($"[{artist}] ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            var genres = applicationContext.Song
                .GroupBy(i => i.GenreId)
                .Select(i => new { Title = i.Key, Count = i.Count() })
                .ToList();

            Console.WriteLine("Task 2:");
            foreach (var genre in genres)
            {
                if (genre.Title == null)
                {
                    Console.WriteLine($"Songs with no genre: {genre.Count}");
                }
                else
                {
                    switch (genre.Title)
                    {
                        case 1:
                            Console.WriteLine($"Rock: {genre.Count}");
                            break;
                        case 2:
                            Console.WriteLine($"Pop: {genre.Count}");
                            break;
                        case 3:
                            Console.WriteLine($"Rap: {genre.Count}");
                            break;
                        case 4:
                            Console.WriteLine($"R&B: {genre.Count}");
                            break;
                        case 5:
                            Console.WriteLine($"Electronica: {genre.Count}");
                            break;
                    }
                }
            }

            Console.WriteLine();

            var theYoungestArtist = applicationContext.Artist.Max(i => i.DateOfBirth);
            var selectedSongs = applicationContext.Song.Where(i => i.ReleasedDate < theYoungestArtist).Include(i => i.SongArtist).ThenInclude(i => i.Artist)
                    .Select(i => new { Title = i.Title, Artists = i.SongArtist.Select(a => a.Artist.Name), Duration = i.Duration, Genre = i.Genre.Title, ReleasedDate = i.ReleasedDate })
                    .ToList();

            Console.WriteLine("Task 3: ");
            foreach (var song in selectedSongs)
            {
                Console.WriteLine($"Title: {song.Title}, ");
                Console.Write("Genre: ");
                if (song.Genre == null)
                {
                    Console.WriteLine("No genre");
                }
                else
                {
                    Console.WriteLine(song.Genre);
                }

                Console.Write("Artists: ");
                foreach (var artist in song.Artists)
                {
                    Console.Write($"[{artist}] ");
                }

                Console.WriteLine();
                Console.WriteLine($"Duration: {song.Duration / 60}m {song.Duration % 60}s, Released date: {song.ReleasedDate.ToString("dd.MM.yyyy")}");
            }

            applicationContext.SaveChanges();
        }
    }
}
