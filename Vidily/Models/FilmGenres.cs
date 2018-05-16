using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidily.Models
{
    public class FilmGenres
    {
        public byte Id { get; set; }
        [Required]
        public string Genre { get; set; }
    }
}