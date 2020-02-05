using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
     public class Music :BaseEntity
    {
        public string Name { get; set; }
        public string File { get; set; }
        public string Poster { get; set; }
        public int ListeningCount { get; set; }
        public bool CaDownload { get; set; }
        public int Duration { get; set; }

        public int AlbomId { get; set; }
        public Albom Albom { get; set; }
    }
}
