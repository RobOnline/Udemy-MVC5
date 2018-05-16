using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidily.Models
{
    public class Movie
    {//
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Released")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [Display (Name="Added")]
        public DateTime DateAdded { get; set; }
        public FilmGenres FilmGenres { get; set; }

        [Required]
        [Display (Name = "Genre")]
        public byte FilmGenresId { get; set; }
        [Required]
        public int Stock { get; set; }


    }

    

}