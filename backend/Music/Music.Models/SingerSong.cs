using System;
using System.Collections.Generic;
using System.Text;

namespace Music.Models
{
    public class SingerSong
    {
        public int SingerId { get; set; }
        public int SongId { get; set; }
        public Singer Singer { get; set; }
        public Song Song { get; set; }

    }
}
