using MoviesSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesSite.Logic
{
    public static class MoviesLogic
    {
        public static List<Movie> Movies { get; set; }

        static MoviesLogic()
        {
            Movies = new List<Movie> {
 new Movie(){ID = 1, Name = "Forrest Gump", Date = 1994, MovieGenre = MovieGenre.Drama, Description = "The presidencies of Kennedy and Johnson, Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.", Image = "https://upload.wikimedia.org/wikipedia/en/thumb/6/67/Forrest_Gump_poster.jpg/220px-Forrest_Gump_poster.jpg"},

new Movie(){ID = 2, Name = "Gladiator", Date = 2000, MovieGenre = MovieGenre.Action, Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.", Image = "http://2sub.tv/uploads/posts/2016-08/1472568285_gladiator.2000.jpg"},

new Movie(){ID = 3, Name = "Saving Private Ryan", Date = 1998, MovieGenre = MovieGenre.War, Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.", Image = "https://upload.wikimedia.org/wikipedia/he/a/ac/Saving_Private_Ryan_poster.jpg"},

new Movie(){ID = 4, Name = "Doctor Zhivago", Date = 1965, Description = "The life of a Russian physician and poet who, although married to another, falls in love with a political activist's wife and experiences hardship during World War I and then the October Revolution.", MovieGenre = MovieGenre.Biography, Image = "https://img.discogs.com/7RGcqx1aFfpUYqjx_ut0CiIGbto=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-2888411-1311541532.jpeg.jpg"},

new Movie(){ID = 5, Name = "Jurassic Park", Date = 1993, Description = "During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.", MovieGenre = MovieGenre.Adventure, Image = "http://www.movieposterdb.com/posters/06_02/1997/0119567/l_90110_0119567_58208d72.jpg"},

new Movie(){ID = 6, Name = "The Silence of the Lambs", Date = 1991, Description = "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.", MovieGenre = MovieGenre.Thriller, Image = "http://2.bp.blogspot.com/-wI4kv4PHG0M/UoKwINQyEhI/AAAAAAAAA_s/YIaebLn7G38/s1600/094-The+Silence+of+The+Lambs+-+Poster.jpg"}
            };
        }

        public static Movie Update(Movie movie)
        {
            var UpdatedMovie = Movies.Where(m => m.ID == movie.ID).FirstOrDefault();
            if (UpdatedMovie != null)
            {
                UpdatedMovie.Name = movie.Name;
                UpdatedMovie.Image = movie.Image;
                UpdatedMovie.Description = movie.Description;
                UpdatedMovie.Date = movie.Date;
                UpdatedMovie.MovieGenre = movie.MovieGenre;
            }

            return UpdatedMovie;
        }

    }
}