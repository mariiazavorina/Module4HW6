using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4HW6.DataAccess.Entities
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public bool IsAlive { get; set; }
        public List<SongArtist> SongArtist { get; set; } = new List<SongArtist>();
    }
}
