using MoviesSite.Logic;
using MoviesSite.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MoviesSite.Controllers
{
    public class MovieController : Controller
    {

        List<Movie> movies = MoviesLogic.Movies;


        // GET: Movie
        public ActionResult Index()
        {
            //List<Movie> movies = MoviesLogic.Movies;
            return View(movies);
        }


        public ActionResult Details(int ID = 0)
        {
            //List<Movie> movies = MoviesLogic.Movies;
            var movie = movies.Where(m => m.ID == ID).FirstOrDefault();
            return View(movie);
        }


        public ActionResult Edit(int ID)
        {
            //List<Movie> movies = MoviesLogic.Movies;

            var movie = movies.Where(m => m.ID == ID).FirstOrDefault();
            return View(movie);
        }


        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            var updated = MoviesLogic.Update(movie);
            return View(updated);
        }


        public ActionResult Delete(int ID)
        {
            { }
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        { return View(); }

        [HttpPost]
        public ActionResult Create(Movie Newmovie)
        {

            //List<Movie> movies = MoviesLogic.Movies;
            if (ModelState.IsValid)
            {
                MoviesLogic.Movies.Add(Newmovie);
               //MoviesLogic. SaveChanges();
                return RedirectToAction("Index");
            }
            else
            { return View(Newmovie); }
        }

    }

}

