using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Music.Models
{
    public class Song: IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Şarkı adı boş geçilemez")]
        [MinLength(2, ErrorMessage ="Şarkı adı en az 2 karakter olmalı")]
        [MaxLength(75, ErrorMessage ="Şarkı adı en fazla 75 karakter olmalı")]
        
        public string SongName { get; set; }
        public double? Duration { get; set; }
        public int MonthlyListener { get; set; }
        public int? GenreId { get; set; } //Foreignkey
        public virtual Genre Genre { get; set; } //NavigationProperty
        public int? AlbumId { get; set; } //Foreignkey
        public virtual Album Album { get; set; } //NavigationProperty
        public virtual IList<SingerSong> Singers { get; set; }
        public virtual IList<AlbumSong> Albums { get; set; }
    }
}
