using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Models
{
    public class AlbumSong
    {
        public int SongId { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
        public Song Song { get; set; }
    }
}
