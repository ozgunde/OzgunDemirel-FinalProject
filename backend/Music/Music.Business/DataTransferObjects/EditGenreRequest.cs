using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Music.Business.DataTransferObjects
{
    public class EditGenreRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Tür adı boş olamaz")]
        public string Name { get; set; }
    }

}
