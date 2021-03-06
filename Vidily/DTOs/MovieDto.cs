﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidily.DTOs
{
    public class MovieDto
    {
       
        public int Id { get; set; }
       
        [StringLength(225)]
        public string Name { get; set; }

      
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }
      

        public byte FilmGenresId { get; set; }

        public byte? Stock { get; set; }
    }
}