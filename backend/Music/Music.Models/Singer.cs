using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Music.Models
{
    public class Singer: IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Sanatçı adı boş geçilemez")]
        [MinLength(2, ErrorMessage = "Sanatçı adı en az 2 karakter olmalı")]
        [MaxLength(75, ErrorMessage = "Sanatçı adı en fazla 75 karakter olmalı")]
        public string SingerName { get; set; }
        public string SingerLastName { get; set; }
        public string Notes { get; set; }
        public virtual IList<SingerSong> Songs { get; set; }

    }
}
