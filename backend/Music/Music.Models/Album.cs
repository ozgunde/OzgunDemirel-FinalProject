using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Music.Models
{
    public class Album : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Albüm adı boş geçilemez")]
        public string AlbumName { get; set; }
        public string AlbumPoster { get; set; }
        public virtual IList<AlbumSong> Songs { get; set; }

    }
}
