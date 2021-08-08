using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Text;

namespace Music.Models
{
    public class Genre : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Türün adı boş geçilemez")]
        public string GenreName { get; set; }
        public virtual IList<Song> Songs { get; set; }

    }
}
