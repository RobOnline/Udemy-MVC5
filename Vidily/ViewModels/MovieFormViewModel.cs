using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidily.Models;
namespace Vidily.ViewModels
{
    public class MovieFormViewModel
    {
       
            public IEnumerable<FilmGenres> FilmGenreses { get; set; }
        
        public int? Id { get; set; }
        [Required]
        [StringLength(225)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Released")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Added")]
        public DateTime? DateAdded { get; set; }
        public FilmGenres FilmGenres { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? FilmGenresId { get; set; }

        [Required]
        [Range(1, 50, ErrorMessage = "Stock must be between 1 and 50")]
        public byte? Stock { get; set; }

        public string Title
        {
            get
            {
                if (Id !=0) return "Edit Movie";
                return "New Movie";

            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
         
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            DateAdded = movie.DateAdded;
            Stock = movie.Stock;
            FilmGenresId = movie.FilmGenresId;
        }


    }
}