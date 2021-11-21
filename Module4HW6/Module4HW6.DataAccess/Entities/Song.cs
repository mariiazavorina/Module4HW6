using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW6.DataAccess.Entities
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int? GenreId { get; set; }
        public Genre Genre { get; set; }
        public List<SongArtist> SongArtist { get; set; } = new List<SongArtist>();
    }
}
