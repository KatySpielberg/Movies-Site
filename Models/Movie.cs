using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MoviesSite.Logic;

namespace MoviesSite.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Please fill the Name of Movie")]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string Name { get; set; }
        public int Date { get; set; }
        [Required]
        [MinLength(15)]
        public string Description { get; set; }
        public string Image { get; set; }
        [Required]
        public MovieGenre MovieGenre { get; set; }
    }

    public enum MovieGenre
    {
        Drama,
        Comedy,
        Clasic,
        Mystery,
        Romance,
        Thriller,
        Biography,
        History,
        Action,
        Adventure,
        War
    }
}