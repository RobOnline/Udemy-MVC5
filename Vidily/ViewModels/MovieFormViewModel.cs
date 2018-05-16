using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidily.Models;
namespace Vidily.ViewModels
{
    public class MovieFormViewModel
    {
       
            public IEnumerable<FilmGenres> FilmGenreses { get; set; }
            public Movie Movie { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0) return "Edit Movie";
                return "New Movie";

            }
        }
       
    }
}