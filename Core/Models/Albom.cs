using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Albom:BaseEntity
    {
        public DateTime RelaiseDate { get; set; }

        public string Poster { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }
        public int ArtistId { get; set; }

        public Artist Artist { get; set; }

        public IEnumerable<Music> Musics { get; set; }
    }
}
